using Refill.Repositories;
using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Refill
{
    public partial class MainForm : Form
    {
        private FuelRepositori _fuelRepositori;
        private CoffeeRepository _coffeeRepository;
        private decimal _sumCoffe;
        private decimal _sumResult;
        private decimal _fullSumDay;
        private Word.Application wordapp;
        private int _numberCheqe;
        
        public MainForm()
        {
            InitializeComponent();
            _fuelRepositori = new FuelRepositori();
            _coffeeRepository = new CoffeeRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbFuel.DataSource = _fuelRepositori.Get();
        }

        #region Fuel
        private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbQuantityFuel.Text = "0";
            tbSumForFuel.Text = "0";
            tbPrice.Text = "0";

            if (cmbFuel.SelectedItem != null)
            {
                if (cmbFuel.SelectedItem is FuelInfo fuelInfo)
                {
                    var price = Convert.ToString((cmbFuel.SelectedItem as FuelInfo).Price);
                    tbPrice.Text = price;
                }
            }
        }

        private void radQuantityFul_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantityFuel.Enabled = true;
            tbSumForFuel.Enabled = false;
            tbSumForFuel.Text = "0";
            lbResultFuel.Text = "К оплате";
            lbCurrencyResult.Text = "р.";
        }

        private void radSumForFuel_CheckedChanged(object sender, EventArgs e)
        {
            tbSumForFuel.Enabled = true;
            tbQuantityFuel.Enabled = false;
            tbQuantityFuel.Text = "0";
            lbResultFuel.Text = "К выдаче";
            lbCurrencyResult.Text = "л.";
        }

        private void tbQuantityFuel_TextChanged(object sender, EventArgs e)
        {
            decimal sum = Convert.ToDecimal(tbPrice.Text) * Convert.ToDecimal(tbQuantityFuel.Text);
            //tbResultFuel.Text = Convert.ToString(Math.Round(sum, 4));
            tbResultFuel.Text = (Math.Round(sum, 4)).ToString("N0");
        }

        private void tbSumForFuel_TextChanged(object sender, EventArgs e)
        {
            decimal sum = Convert.ToDecimal(tbSumForFuel.Text) / Convert.ToDecimal(tbPrice.Text);
            tbResultFuel.Text = Convert.ToString(Math.Round(sum, 4));
        }

        private void tbQuantityFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputFuel(e);
        }

        private void tbSumForFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputFuel(e);
        }


        #endregion

        #region Coffee
        private void chkHotDog_CheckedChanged(object sender, EventArgs e)
        {
            tbHotDogQauntity.ReadOnly = !chkHotDog.Checked;
            if (chkHotDog.Checked == false)
            {
                tbHotDogQauntity.Text = "0";
            }
        }

        private void chkGamburger_CheckedChanged(object sender, EventArgs e)
        {
            tbGamburgerQuantity.ReadOnly = !chkGamburger.Checked;
            if (chkGamburger.Checked == false)
            {
                tbGamburgerQuantity.Text = "0";
            }
        }

        private void chkCheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            tbCheeseburgerQuantity.ReadOnly = !chkCheeseburger.Checked;
            if (chkCheeseburger.Checked == false)
            {
                tbCheeseburgerQuantity.Text = "0";
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            tbColaQuantity.ReadOnly = !chkCola.Checked;
            if (chkCola.Checked == false)
            {
                tbColaQuantity.Text = "0";
            }
        }

        private void tbHotDogQauntity_TextChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32((sender as TextBox).Text);
            string controlName = chkHotDog.Text;

            if (chkHotDog.Checked)
            {
                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
            else
            {
                quantity = 0;

                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
        }

        private void tbGamburgerQuantity_TextChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32((sender as TextBox).Text);
            var controlName = chkGamburger.Text;

            if (chkGamburger.Checked)
            {
                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
            else
            {
                quantity = 0;

                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }

        }

        private void tbCheeseburgerQuantity_TextChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32((sender as TextBox).Text);
            var controlName = chkCheeseburger.Text;

            if (chkCheeseburger.Checked)
            {
                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
            else
            {
                quantity = 0;

                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
        }

        private void tbColaQuantity_TextChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32((sender as TextBox).Text);
            var controlName = chkCola.Text;

            if (chkCola.Checked)
            {
                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
            else
            {
                quantity = 0;

                GetSumItem(quantity, controlName);
                GetResultSumCoffee();
            }
        }

        private void GetResultSumCoffee()
        {
            _sumCoffe = 0;

            foreach (var item in _coffeeRepository.Get())
            {
                _sumCoffe += item.SumPrice;
            }

            tbResultCoffe.Text = _sumCoffe.ToString("N0");
        }

        private void GetSumItem(int quantity, string name)
        {
            foreach (var item in _coffeeRepository.Get())
            {
                if (item.Name == name)
                {
                    item.SumPrice = item.Price * quantity;
                }
            }
        }

        private void tbHotDogQauntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputCoffee(e);
        }

        private void tbGamburgerQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputCoffee(e);
        }

        private void tbCheeseburgerQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputCoffee(e);
        }

        private void tbColaQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCorrectInputCoffee(e);
        }

        #endregion

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(radSumForFuel.Checked)
            {
                _sumResult = Convert.ToDecimal(tbSumForFuel.Text) + Convert.ToDecimal(tbResultCoffe.Text);
                _fullSumDay += _sumResult;
                tbResult.Text = _sumResult.ToString("N0");
                SaveСheque();
                return;
            }

            
            _sumResult = Convert.ToDecimal(tbResultFuel.Text) + Convert.ToDecimal(tbResultCoffe.Text);
            _fullSumDay += _sumResult;
            tbResult.Text = Math.Round(_sumResult, 4).ToString("N0");
            SaveСheque();
        }

        private void CheckCorrectInputFuel(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
                MessageBox.Show("Введите цифровое значение.\nИспользуйте запятую вместо точки.", "Неверный ввод");
                return;
            }
        }

        private void CheckCorrectInputCoffee(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Введите цифровое значение.\nВведите целое число.", "Неверный ввод");
                return;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"День окончен.\nВыручка за день: {_fullSumDay.ToString("N0")} руб.", "Окончание работы");
        }

        private void SaveСheque()
        {
            
            wordapp = new Word.Application();
            wordapp.Visible = true;
            Word.Paragraph wordparagraph;
            Word.Document doc = new Word.Document();
            object MyTemplate = Type.Missing;
            object NewTemplate = false; 
            object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object Visible = true; 
            doc = wordapp.Documents.Add(ref MyTemplate,
                                         ref NewTemplate,
                                         ref DocumentType,
                                         ref Visible);

            
            object pargf = Type.Missing;
            wordparagraph = doc.Content.Paragraphs.Add(ref pargf);
            wordparagraph.Range.Font.Bold = 1;           
            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Text = $"Чек №{++_numberCheqe}";            
           
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = (DateTime.Now).ToString();

            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Text = "Ваш заказ: ";

            foreach (var item in _fuelRepositori.Get())
            {
                if (cmbFuel.Text == item.Name)
                {
                    if (radQuantityFul.Checked)
                    {
                        if (Convert.ToDecimal(tbQuantityFuel.Text) == 0)
                        {
                            break;
                        }

                        decimal sum = item.Price * Convert.ToDecimal(tbQuantityFuel.Text);
                        wordparagraph.Range.InsertParagraphAfter();
                        wordparagraph.Range.Font.Size = 14;
                        wordparagraph.Range.Text = $"{item.Name}\t\t{item.Price.ToString()}руб x {tbQuantityFuel.Text}л.\t\t{sum.ToString("N0")} руб";
                    }

                    if (radSumForFuel.Checked)
                    {
                        if (Convert.ToDecimal(tbSumForFuel.Text) == 0)
                        {
                            break;
                        }

                        decimal sum = Convert.ToDecimal(tbSumForFuel.Text)/ item.Price;
                        wordparagraph.Range.InsertParagraphAfter();
                        wordparagraph.Range.Font.Size = 14;
                        wordparagraph.Range.Text = $"{item.Name}\t\t{tbSumForFuel.Text}руб./{item.Price.ToString()}руб \t\t{Math.Round(sum, 4)} л.";
                                                
                    }
                }
            }

            foreach (var item in _coffeeRepository.Get())
            {
                if (item.Name == chkHotDog.Text && chkHotDog.Checked)
                {
                    if (Convert.ToDecimal(tbHotDogQauntity.Text) == 0)
                    {
                        break;
                    }

                    decimal sum = item.Price * Convert.ToDecimal(tbHotDogQauntity.Text);
                    wordparagraph.Range.InsertParagraphAfter();
                    wordparagraph.Range.Font.Size = 14;
                    wordparagraph.Range.Text = $"{item.Name}\t {item.Price.ToString()}руб x {tbHotDogQauntity.Text} \t\t{sum.ToString("N0")} руб";
                }
                else if (item.Name == chkGamburger.Text && chkGamburger.Checked)
                {
                    if (Convert.ToDecimal(tbGamburgerQuantity.Text) == 0)
                    {
                        break;
                    }

                    decimal sum = item.Price * Convert.ToDecimal(tbGamburgerQuantity.Text);
                    wordparagraph.Range.InsertParagraphAfter();
                    wordparagraph.Range.Font.Size = 14;
                    wordparagraph.Range.Text = $"{item.Name}\t {item.Price.ToString()}руб x {tbGamburgerQuantity.Text}\t\t{sum.ToString("N0")} руб";
                }
                else if (item.Name == chkCheeseburger.Text && chkCheeseburger.Checked)
                {
                    if (Convert.ToDecimal(tbCheeseburgerQuantity.Text) == 0)
                    {
                        break;
                    }

                    decimal sum = item.Price * Convert.ToDecimal(tbCheeseburgerQuantity.Text);
                    wordparagraph.Range.InsertParagraphAfter();
                    wordparagraph.Range.Font.Size = 14;
                    wordparagraph.Range.Text = $"{item.Name}\t {item.Price.ToString()}руб x {tbCheeseburgerQuantity.Text}\t\t{sum.ToString("N0")} руб";
                }
                else if (item.Name == chkCola.Text && chkCola.Checked)
                {
                    if (Convert.ToDecimal(tbColaQuantity.Text) == 0)
                    {
                        break;
                    }

                    decimal sum = item.Price * Convert.ToDecimal(tbColaQuantity.Text);
                    wordparagraph.Range.InsertParagraphAfter();
                    wordparagraph.Range.Font.Size = 14;
                    wordparagraph.Range.Text = $"{item.Name}\t {item.Price.ToString()}руб x {tbColaQuantity.Text} \t\t{sum.ToString("N0")} руб";
                }

            }

            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 16;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Text = $"Итого: {tbResult.Text} руб.";
        }

    }
}
