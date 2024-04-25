using System.Diagnostics;

namespace SortingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string napis = textBox1.Text;
                if (string.IsNullOrEmpty(napis))
                {
                    MessageBox.Show("Brak wprowadzonych liczb");
                    return;
                }

                int[] tab = Convert(napis);
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message);
            }
        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
                liczby[i] = int.Parse(liczbyS[i]);
            return liczby;
        }

        private void NumberGenerator_ValueChanged(object sender, EventArgs e)
        {
            NumberGenerator.Maximum = 2000000;
        }

        private int[] generatedTab = new int[] { };
        private void Generate_Click(object sender, EventArgs e)
        {
            if (GenerujLiczby.Checked)
            {
                int iloscElementow = (int)NumberGenerator.Value;
                generatedTab = WygenerujTablice(iloscElementow, 0, 1000);
            }
        }

        int[] WygenerujTablice(int dlugosc, int min, int max)
        {
            var rand = new Random();
            int[] tab = new int[dlugosc];
            for (int i = 0; i < dlugosc; i++)
                tab[i] = rand.Next(min, max);
            return tab;
        }

        private void SBubble_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            textBox2.Clear();
            timer.Start();
            if (GenerujLiczby.Checked)
            {
                int[] wynik = BubbleSort(generatedTab);
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
            else
            {
                string napis = textBox1.Text;
                int[] tab = Convert(napis);
                int[] wynik = BubbleSort(tab);
                foreach (int i in wynik)
                {
                    textBox2.Text += i.ToString() + " ";
                }
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
        }

        int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1 - i; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        var temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
            return tab;
        }

        private void SSelection_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            textBox2.Clear();
            timer.Start();
            if (GenerujLiczby.Checked)
            {
                int[] wynik = SelectionSort(generatedTab);
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
            else
            {
                string napis = textBox1.Text;
                int[] tab = Convert(napis);
                int[] wynik = SelectionSort(tab);
                foreach (int i in wynik)
                {
                    textBox2.Text += i.ToString() + " ";
                }
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
        }

        int[] SelectionSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int minimal_element = tab[i];
                int minimal_id = i;
                for (int k = i; k < tab.Length; k++)
                {
                    if (tab[k] < minimal_element)
                    {
                        minimal_element = tab[k];
                        minimal_id = k;
                    }
                }
                var temp = tab[i];
                tab[i] = tab[minimal_id];
                tab[minimal_id] = temp;
            }
            return tab;
        }

        private void SInsertion_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            textBox2.Clear();
            timer.Start();
            if (GenerujLiczby.Checked)
            {
                int[] wynik = InsertionSort(generatedTab);
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
            else
            {
                string napis = textBox1.Text;
                int[] tab = Convert(napis);
                int[] wynik = InsertionSort(tab);
                foreach (int i in wynik)
                {
                    textBox2.Text += i.ToString() + " ";
                }
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
        }

        int[] InsertionSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int klucz = tab[i];
                int j = i - 1;
                while (j >= 0 && tab[j] > klucz)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = klucz;
            }
            return tab;
        }

        private void SMerge_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            textBox2.Clear();
            timer.Start();
            if (GenerujLiczby.Checked)
            {
                int[] wynik = MergeSort(generatedTab, 0, generatedTab.Length - 1);
                foreach (int i in wynik)
                    timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
            else
            {
                string napis = textBox1.Text;
                int[] tab = Convert(napis);
                int[] wynik = MergeSort(tab, 0, tab.Length - 1);
                foreach (int i in wynik)
                {
                    textBox2.Text += i.ToString() + " ";
                }
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
        }

        int[] MergeSort(int[] tab, int left, int right)
        {
            if (tab.Length <= 1)
                return tab;

            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(tab, left, mid);
                MergeSort(tab, mid + 1, right);
                Scalak(tab, left, mid, right);
            }
            return tab;
        }

        void Scalak(int[] tab, int left, int mid, int right)
        {
            int[] LeftTemp = new int[mid - left + 1];
            int[] RightTemp = new int[right - mid];
            int i, j;
            for (i = 0; i < mid - left + 1; ++i)
                LeftTemp[i] = tab[left + i];
            for (j = 0; j < right - mid; j++)
                RightTemp[j] = tab[mid + 1 + j];
            i = 0;
            j = 0;
            int k = left;

            while (i < mid - left + 1 && j < right - mid)
            {
                if (LeftTemp[i] <= RightTemp[j])
                    tab[k++] = LeftTemp[i++];
                else
                    tab[k++] = RightTemp[j++];
            }

            while (i < mid - left + 1)
                tab[k++] = LeftTemp[i++];

            while (j < right - mid)
                tab[k++] = RightTemp[j++];

        }

        private void SQuick_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            textBox2.Clear();
            timer.Start();
            if (GenerujLiczby.Checked)
            {
                int[] wynik = QuickSort(generatedTab, 0, generatedTab.Length - 1);
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
            else
            {
                string napis = textBox1.Text;
                int[] tab = Convert(napis);
                int[] wynik = QuickSort(tab, 0, tab.Length - 1);
                foreach (int i in wynik)
                {
                    textBox2.Text += i.ToString() + " ";
                }
                timer.Stop();
                double czasTrwania = timer.Elapsed.TotalSeconds;
                label2.Text = czasTrwania.ToString("F4") + " sek.";
            }
        }
        int[] QuickSort(int[] tab, int left, int right)
        {
            if (tab.Length <= 1)
                return tab;

            int i = left;
            int j = right;
            int pivot = tab[left];
            while (i <= j)
            {
                while (tab[i] < pivot)
                    i++;

                while (tab[j] > pivot)
                    j--;

                if (i <= j)
                {
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(tab, left, j);

            if (i < right)
                QuickSort(tab, i, right);

            return tab;
        }
    }
}