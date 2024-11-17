using Microsoft.ML;
using Microsoft.ML.Data;
using ScottPlot;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HousePriceAnalyzer
{
    public partial class HousePriceAnalyzerForm : Form
    {
        private List<HouseData> houseDataList;
        private ITransformer trainedModel;
        private MLContext mlContext;


        public HousePriceAnalyzerForm()
        {
            InitializeComponent();
            LoadData();
            PrintAllRecords();
            ShowPriceHistogram();  // Show the price histogram
        }

        private void LoadData()
        {
            // Initialize MLContext
            mlContext = new MLContext();

            // Path to your CSV file
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Housing.csv");


            // Load the data into an IDataView
            IDataView dataView = mlContext.Data.LoadFromTextFile<HouseData>(
                dataPath,
                separatorChar: ',',
                hasHeader: true
            );

            // Convert IDataView to an enumerable and store all records in a list
            houseDataList = mlContext.Data.CreateEnumerable<HouseData>(dataView, reuseRowObject: false).ToList();


            // Split the data into training and test sets
            var splitData = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

            // Define the data preparation and training pipeline
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new[]
                {
            new InputOutputColumnPair("mainroad"),
            new InputOutputColumnPair("guestroom"),
            new InputOutputColumnPair("basement"),
            new InputOutputColumnPair("hotwaterheating"),
            new InputOutputColumnPair("airconditioning"),
            new InputOutputColumnPair("prefarea"),
            new InputOutputColumnPair("furnishingstatus")
        })
                .Append(mlContext.Transforms.Concatenate("Features", new[]
                {
            "area", "bedrooms", "bathrooms", "stories", "parking",
            "mainroad", "guestroom", "basement", "hotwaterheating",
            "airconditioning", "prefarea", "furnishingstatus"
                }))
                .Append(mlContext.Transforms.NormalizeMinMax("Features")) // Add normalization here
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "price", featureColumnName: "Features", maximumNumberOfIterations: 100));

            // Train the model
            trainedModel = pipeline.Fit(splitData.TrainSet);

            // Evaluate the model on the test set
            var predictions = trainedModel.Transform(splitData.TestSet);
            var metrics = mlContext.Regression.Evaluate(predictions, labelColumnName: "price");

            // Print evaluation metrics to the console
            System.Diagnostics.Debug.WriteLine($"R-Squared: {metrics.RSquared:0.##}");
            System.Diagnostics.Debug.WriteLine($"Mean Absolute Error: {metrics.MeanAbsoluteError:0.##}");
            System.Diagnostics.Debug.WriteLine($"Mean Squared Error: {metrics.MeanSquaredError:0.##}");
            System.Diagnostics.Debug.WriteLine($"Root Mean Squared Error: {metrics.RootMeanSquaredError:0.##}");
        }

        private void PrintAllRecords()
        {
            // Clear the RichTextBox before appending new records
            richTextBox1.Clear();
            int counter = 1;

            // Print each record in the RichTextBox
            foreach (var house in houseDataList)  // Loop through all records
            {
                //System.Diagnostics.Debug.WriteLine($"price: {house.price}, area: {house.area}, bathrooms: {house.bathrooms}");
                richTextBox1.AppendText($"record: {counter}, price: {house.price}, area: {house.area}, bedrooms: {house.bedrooms}, bathrooms: {house.bathrooms}, stories: {house.stories}, " +
                                        $"mainroad: {house.mainroad}, guestroom: {house.guestroom}, basement: {house.basement}, hotwaterheating: {house.hotwaterheating}, " +
                                        $"airconditioning: {house.airconditioning}, parking: {house.parking}, prefarea: {house.prefarea}, furnishingstatus: {house.furnishingstatus}{Environment.NewLine}{Environment.NewLine}");
                counter++;
            }
        }


        private void ShowPriceHistogram()
        {
            // Step 1: Extract price data from houseDataList
            double[] prices = houseDataList.Select(h => (double)h.price).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: prices.Min(), max: prices.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(prices);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            //formsPlot.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            //formsPlot.Plot.AddBar(values: counts, positions: binCenters);
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            //formsPlot.Plot.YAxis.Label("Count (#)");
            //formsPlot.Plot.XAxis.Label("Price");
            //formsPlot.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Price");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            //formsPlot.Refresh();
            formsPlotGeneric.Refresh();

            // bivariate tab - prepare
            // Extract price and area data from houseDataList
            prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] areas = houseDataList.Select(house => (double)house.area).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, areas);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("Area (sq ft)");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. Area");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();


            // labelPrepArea Prepare
            this.labelPredArea.Text = this.trackBar1.Value.ToString();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] prices = houseDataList.Select(h => (double)h.price).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: prices.Min(), max: prices.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(prices);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Price Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] stories = houseDataList.Select(h => (double)h.stories).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: stories.Min(), max: stories.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(stories);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Stories Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] bathrooms = houseDataList.Select(h => (double)h.bathrooms).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: bathrooms.Min(), max: bathrooms.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(bathrooms);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Bathrooms Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] area = houseDataList.Select(h => (double)h.area).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: area.Min(), max: area.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(area);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("area Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.mainroad.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.mainroad.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Mainroad");

            formsPlotGeneric.Refresh();
        }

        private void radioGuestRoom_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.guestroom.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.guestroom.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Guestroom");

            formsPlotGeneric.Refresh();
        }

        private void radioButtonBasement_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.basement.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.basement.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Basement");

            formsPlotGeneric.Refresh();
        }

        private void radioButtonhotwaterheating_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.hotwaterheating.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.hotwaterheating.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Hotwaterheating");

            formsPlotGeneric.Refresh();
        }

        private void radioButtonAirconditioning_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.airconditioning.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.airconditioning.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Airconditioning");

            formsPlotGeneric.Refresh();
        }

        private void radioButtonParking_CheckedChanged(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] parking = houseDataList.Select(h => (double)h.parking).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: parking.Min(), max: parking.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(parking);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Parking Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButtonPrefarea_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.prefarea.ToLower() == "yes");
            int noCount = houseDataList.Count(house => house.prefarea.ToLower() == "no");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "Yes", "No" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Prefarea");

            formsPlotGeneric.Refresh();
        }

        private void radioButtonFurnishingstatus_CheckedChanged(object sender, EventArgs e)
        {
            // Count the "yes" and "no" occurrences in mainroad
            int yesCount = houseDataList.Count(house => house.furnishingstatus.ToLower() == "furnished");
            int noCount = houseDataList.Count(house => house.furnishingstatus.ToLower() == "semi-furnished");

            // Prepare data for the bar graph
            double[] counts = { yesCount, noCount };  // Counts for "yes" and "no"
            string[] labels = { "furnished", "semi-furnished" };        // Labels for the X-axis

            formsPlotGeneric.Plot.Clear();
            formsPlotGeneric.Plot.AddBar(values: counts);
            formsPlotGeneric.Plot.XTicks(new double[] { 0, 1 }, labels);
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);
            formsPlotGeneric.Plot.YLabel("Count");
            formsPlotGeneric.Plot.XLabel("Furnishingstatus");

            formsPlotGeneric.Refresh();
        }

        private void radioButton4_CheckedChanged_2(object sender, EventArgs e)
        {
            // Step 1: Extract price data from houseDataList
            double[] price = houseDataList.Select(h => (double)h.price).ToArray();

            // Step 2: Create a histogram based on the price data
            ScottPlot.Statistics.Histogram hist = new(min: price.Min(), max: price.Max(), binCount: 50);

            // Step 3: Plot the histogram using bar chart
            hist.AddRange(price);
            double[] counts = hist.Counts;  // Get the counts for each bin
            double[] binCenters = hist.BinCenters;  // Get the bin centers for the X-axis

            // Step 4: Clear the plot to ensure it's empty before adding new data
            formsPlotGeneric.Plot.Clear();

            // Step 5: Add bar chart for the histogram
            formsPlotGeneric.Plot.AddBar(values: counts, positions: binCenters);

            // Step 6: Customize the plot
            formsPlotGeneric.Plot.YAxis.Label("Count (#)");
            formsPlotGeneric.Plot.XAxis.Label("Price Histogram");
            formsPlotGeneric.Plot.SetAxisLimits(yMin: 0);  // Set the Y-axis minimum to 0

            // Step 7: Refresh the plot to display the changes
            formsPlotGeneric.Refresh();
        }

        private void radioButtonBarea_CheckedChanged(object sender, EventArgs e)
        {
            // Extract price and area data from houseDataList
            double[] prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] areas = houseDataList.Select(house => (double)house.area).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, areas);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("Area (sq ft)");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. Area");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();
        }

        private void radioButtonBbedrooms_CheckedChanged(object sender, EventArgs e)
        {
            // Extract price and area data from houseDataList
            double[] prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] bedrooms = houseDataList.Select(house => (double)house.bedrooms).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, bedrooms);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("number of bedrooms");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. Bedrooms");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();
        }

        private void radioButtonBbathrooms_CheckedChanged(object sender, EventArgs e)
        {
            // Extract price and area data from houseDataList
            double[] prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] bathrooms = houseDataList.Select(house => (double)house.bathrooms).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, bathrooms);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("number of bathrooms");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. bathrooms");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();
        }

        private void radioButtonBstories_CheckedChanged(object sender, EventArgs e)
        {
            // Extract price and area data from houseDataList
            double[] prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] stories = houseDataList.Select(house => (double)house.stories).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, stories);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("number of stories");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. stories");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();
        }

        private void radioButtonBmainroad_CheckedChanged(object sender, EventArgs e)
        {
            var pricesMainroadYes = houseDataList
        .Where(house => house.mainroad == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesMainroadNo = houseDataList
                .Where(house => house.mainroad == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesMainroadYes);
            var popB = new ScottPlot.Statistics.Population(pricesMainroadNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }

        private void radioButtonBguestroom_CheckedChanged(object sender, EventArgs e)
        {
            var pricesGuestRoomYes = houseDataList
        .Where(house => house.guestroom == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesGuestRoomNo = houseDataList
                .Where(house => house.guestroom == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesGuestRoomYes);
            var popB = new ScottPlot.Statistics.Population(pricesGuestRoomNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }

        private void radioButtonBbasement_CheckedChanged(object sender, EventArgs e)
        {
            var pricesBasementYes = houseDataList
        .Where(house => house.basement == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesBasementNo = houseDataList
                .Where(house => house.basement == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesBasementYes);
            var popB = new ScottPlot.Statistics.Population(pricesBasementNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }



        private void radioButtonBhotwaterheating_CheckedChanged_1(object sender, EventArgs e)
        {
            var pricesHotwaterheatingYes = houseDataList
        .Where(house => house.hotwaterheating == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesHotwaterheatingNo = houseDataList
                .Where(house => house.hotwaterheating == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesHotwaterheatingYes);
            var popB = new ScottPlot.Statistics.Population(pricesHotwaterheatingNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }

        private void radioButtonBairconditioning_CheckedChanged(object sender, EventArgs e)
        {
            var pricesAirconditioningYes = houseDataList
        .Where(house => house.airconditioning == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesAirconditioningNo = houseDataList
                .Where(house => house.airconditioning == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesAirconditioningYes);
            var popB = new ScottPlot.Statistics.Population(pricesAirconditioningNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }

        private void radioButtonBparking_CheckedChanged(object sender, EventArgs e)
        {
            // Extract price and area data from houseDataList
            double[] prices = houseDataList.Select(house => (double)house.price).ToArray();
            double[] parking = houseDataList.Select(house => (double)house.parking).ToArray();

            formsPlotBivariate.Plot.Clear();

            // Add scatter plot using prices for the X-axis and areas for the Y-axis
            formsPlotBivariate.Plot.AddScatter(prices, parking);

            // Customize the plot
            formsPlotBivariate.Plot.XLabel("Price");
            formsPlotBivariate.Plot.YLabel("number of parking spaces");
            formsPlotBivariate.Plot.Title("Scatter Plot of Price vs. parking spaces");

            // Set axis limits (optional, if you want to restrict the view)
            formsPlotBivariate.Plot.SetAxisLimits(yMin: 0, xMin: 0);

            // Clear the previous plot (if any) and display the new scatter plot on the form
            formsPlotBivariate.Refresh();
        }

        private void radioButtonBprefarea_CheckedChanged(object sender, EventArgs e)
        {
            var pricesPrefareaYes = houseDataList
        .Where(house => house.prefarea == "yes")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesPrefareaNo = houseDataList
                .Where(house => house.prefarea == "no")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesPrefareaYes);
            var popB = new ScottPlot.Statistics.Population(pricesPrefareaNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "yes", "no" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }

        private void radioButtonBfurnishingstatus_CheckedChanged(object sender, EventArgs e)
        {
            var pricesFurnishingstatusYes = houseDataList
        .Where(house => house.furnishingstatus == "furnished")
        .Select(house => (double)house.price)
        .ToArray();

            var pricesFurnishingstatusNo = houseDataList
                .Where(house => house.furnishingstatus == "semi-furnished")
                .Select(house => (double)house.price)
                .ToArray();

            // create population objects for each set of data values
            var popA = new ScottPlot.Statistics.Population(pricesFurnishingstatusYes);
            var popB = new ScottPlot.Statistics.Population(pricesFurnishingstatusNo);


            formsPlotBivariate.Plot.Clear();

            // combine several populations into an array and plot it
            var poulations = new ScottPlot.Statistics.Population[] { popA, popB };
            string[] populationNames = { "furnished", "semi-furnished" };


            formsPlotBivariate.Plot.AddPopulations(poulations);

            // improve the style of the plot
            formsPlotBivariate.Plot.XAxis.Grid(false);
            formsPlotBivariate.Plot.XTicks(populationNames);

            formsPlotBivariate.Refresh();
        }



        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.labelPredArea.Text = this.trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the model has been trained
            if (trainedModel == null)
            {
                MessageBox.Show("Model has not been trained. Load data and train the model first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize the PredictionEngine
            var predictionEngine = mlContext.Model.CreatePredictionEngine<HouseData, HousePricePrediction>(trainedModel);

            // Create a sample input (You can replace these values with inputs from textboxes or other controls)
            var sampleInput = new HouseData
            {

                area = 3950,                // Example value
                bedrooms =4,               // Example value
                bathrooms =1,              // Example value
                stories = 2,                // Example value
                parking = 0,                // Example value
                mainroad = "yes",            // Example value
                guestroom = "no",            // Example value
                basement = "no",             // Example value
                hotwaterheating = "no",      // Example value
                airconditioning = "no",     // Example value
                prefarea = "no",            // Example value
                furnishingstatus = "unfurnished" // Example value
            };

            // Predict the price
            var prediction = predictionEngine.Predict(sampleInput);

            // Display the prediction
            MessageBox.Show($"Predicted Price: {prediction.Price}", "Prediction Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class HouseData
    {

        [LoadColumn(0)]
        public float price { get; set; }

        [LoadColumn(1)]
        public float area { get; set; }

        [LoadColumn(2)]
        public float bedrooms { get; set; }

        [LoadColumn(3)]
        public float bathrooms { get; set; }

        [LoadColumn(4)]
        public float stories { get; set; }

        [LoadColumn(5)]
        public string mainroad { get; set; }

        [LoadColumn(6)]
        public string guestroom { get; set; }

        [LoadColumn(7)]
        public string basement { get; set; }

        [LoadColumn(8)]
        public string hotwaterheating { get; set; }

        [LoadColumn(9)]
        public string airconditioning { get; set; }

        [LoadColumn(10)]
        public float parking { get; set; }

        [LoadColumn(11)]
        public string prefarea { get; set; }

        [LoadColumn(12)]
        public string furnishingstatus { get; set; }


    }

    public class HousePricePrediction
    {
        public float Price { get; set; }
    }
}
