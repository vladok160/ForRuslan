namespace ForRuslan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawGraph_Click(object sender, EventArgs e)
        {
            GeneralData generalData = new GeneralData();
            GraphF.Series.Clear();
            GraphF.Series.Add("График функции");
            GraphF.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Линейный график
            for (double x = -10; x <= 10; x += 0.1)
            {
                GraphF.Series[0].Points.AddXY(x, generalData.func(x));
            }
        }

        private void MethodOfUnevenCoatings_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods(
                Convert.ToDouble(X0.Text),
                Convert.ToDouble(X1.Text),
                Convert.ToDouble(E.Text),
                Convert.ToDouble(1));
            xMin.Text = Convert.ToString(methods.ForX());
            yMin.Text = Convert.ToString(methods.ForF());
            Iter.Text = Convert.ToString(methods.GetIterations());
            Time.Text = Convert.ToString(methods.TimeOfDoing());
        }

        private void BruteForceMethod_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods(
                Convert.ToDouble(X0.Text),
                Convert.ToDouble(X1.Text),
                Convert.ToDouble(E.Text));
            xMin.Text = Convert.ToString(methods.ForX());
            yMin.Text = Convert.ToString(methods.ForF());
            Iter.Text = Convert.ToString(methods.GetIterations());
            Time.Text = Convert.ToString(methods.TimeOfDoing());
        }
    }
}