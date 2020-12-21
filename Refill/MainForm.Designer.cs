namespace Refill
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpFuel = new System.Windows.Forms.GroupBox();
            this.grpResultFuel = new System.Windows.Forms.GroupBox();
            this.lbCurrencyResult = new System.Windows.Forms.Label();
            this.tbResultFuel = new System.Windows.Forms.TextBox();
            this.lbResultFuel = new System.Windows.Forms.Label();
            this.lbCurrency1 = new System.Windows.Forms.Label();
            this.grpQuantityFuel = new System.Windows.Forms.GroupBox();
            this.lbQuantityL = new System.Windows.Forms.Label();
            this.lbCurrency2 = new System.Windows.Forms.Label();
            this.tbSumForFuel = new System.Windows.Forms.TextBox();
            this.tbQuantityFuel = new System.Windows.Forms.TextBox();
            this.radSumForFuel = new System.Windows.Forms.RadioButton();
            this.radQuantityFul = new System.Windows.Forms.RadioButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.lbFuel = new System.Windows.Forms.Label();
            this.grpCoffee = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCurrencyResultCoffe = new System.Windows.Forms.Label();
            this.tbResultCoffe = new System.Windows.Forms.TextBox();
            this.lbRusulCoffe = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbColaQuantity = new System.Windows.Forms.TextBox();
            this.tbCheeseburgerQuantity = new System.Windows.Forms.TextBox();
            this.tbGamburgerQuantity = new System.Windows.Forms.TextBox();
            this.tbHotDogQauntity = new System.Windows.Forms.TextBox();
            this.lbCurrencyCoffe4 = new System.Windows.Forms.Label();
            this.lbCurrencyCoffe3 = new System.Windows.Forms.Label();
            this.lbCurrencyCoffe2 = new System.Windows.Forms.Label();
            this.lbCurrencyCoffe1 = new System.Windows.Forms.Label();
            this.tbCola = new System.Windows.Forms.TextBox();
            this.tbCheeseburger = new System.Windows.Forms.TextBox();
            this.tbGamburger = new System.Windows.Forms.TextBox();
            this.tbHotDog = new System.Windows.Forms.TextBox();
            this.lpPrice = new System.Windows.Forms.Label();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.chkCheeseburger = new System.Windows.Forms.CheckBox();
            this.chkGamburger = new System.Windows.Forms.CheckBox();
            this.chkHotDog = new System.Windows.Forms.CheckBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.grpFuel.SuspendLayout();
            this.grpResultFuel.SuspendLayout();
            this.grpQuantityFuel.SuspendLayout();
            this.grpCoffee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuel
            // 
            this.grpFuel.Controls.Add(this.grpResultFuel);
            this.grpFuel.Controls.Add(this.lbCurrency1);
            this.grpFuel.Controls.Add(this.grpQuantityFuel);
            this.grpFuel.Controls.Add(this.tbPrice);
            this.grpFuel.Controls.Add(this.lbPrice);
            this.grpFuel.Controls.Add(this.cmbFuel);
            this.grpFuel.Controls.Add(this.lbFuel);
            this.grpFuel.Location = new System.Drawing.Point(45, 34);
            this.grpFuel.Name = "grpFuel";
            this.grpFuel.Size = new System.Drawing.Size(351, 337);
            this.grpFuel.TabIndex = 0;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Топливо";
            // 
            // grpResultFuel
            // 
            this.grpResultFuel.Controls.Add(this.lbCurrencyResult);
            this.grpResultFuel.Controls.Add(this.tbResultFuel);
            this.grpResultFuel.Controls.Add(this.lbResultFuel);
            this.grpResultFuel.Location = new System.Drawing.Point(21, 236);
            this.grpResultFuel.Name = "grpResultFuel";
            this.grpResultFuel.Size = new System.Drawing.Size(303, 86);
            this.grpResultFuel.TabIndex = 6;
            this.grpResultFuel.TabStop = false;
            // 
            // lbCurrencyResult
            // 
            this.lbCurrencyResult.AutoSize = true;
            this.lbCurrencyResult.Location = new System.Drawing.Point(267, 42);
            this.lbCurrencyResult.Name = "lbCurrencyResult";
            this.lbCurrencyResult.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyResult.TabIndex = 8;
            this.lbCurrencyResult.Text = "руб.";
            // 
            // tbResultFuel
            // 
            this.tbResultFuel.Location = new System.Drawing.Point(14, 35);
            this.tbResultFuel.Name = "tbResultFuel";
            this.tbResultFuel.ReadOnly = true;
            this.tbResultFuel.Size = new System.Drawing.Size(247, 20);
            this.tbResultFuel.TabIndex = 9;
            this.tbResultFuel.Text = "0";
            // 
            // lbResultFuel
            // 
            this.lbResultFuel.AutoSize = true;
            this.lbResultFuel.Location = new System.Drawing.Point(6, 16);
            this.lbResultFuel.Name = "lbResultFuel";
            this.lbResultFuel.Size = new System.Drawing.Size(52, 13);
            this.lbResultFuel.TabIndex = 8;
            this.lbResultFuel.Text = "К оплате";
            // 
            // lbCurrency1
            // 
            this.lbCurrency1.AutoSize = true;
            this.lbCurrency1.Location = new System.Drawing.Point(273, 86);
            this.lbCurrency1.Name = "lbCurrency1";
            this.lbCurrency1.Size = new System.Drawing.Size(27, 13);
            this.lbCurrency1.TabIndex = 5;
            this.lbCurrency1.Text = "руб.";
            // 
            // grpQuantityFuel
            // 
            this.grpQuantityFuel.Controls.Add(this.lbQuantityL);
            this.grpQuantityFuel.Controls.Add(this.lbCurrency2);
            this.grpQuantityFuel.Controls.Add(this.tbSumForFuel);
            this.grpQuantityFuel.Controls.Add(this.tbQuantityFuel);
            this.grpQuantityFuel.Controls.Add(this.radSumForFuel);
            this.grpQuantityFuel.Controls.Add(this.radQuantityFul);
            this.grpQuantityFuel.Location = new System.Drawing.Point(21, 116);
            this.grpQuantityFuel.Name = "grpQuantityFuel";
            this.grpQuantityFuel.Size = new System.Drawing.Size(310, 98);
            this.grpQuantityFuel.TabIndex = 4;
            this.grpQuantityFuel.TabStop = false;
            // 
            // lbQuantityL
            // 
            this.lbQuantityL.AutoSize = true;
            this.lbQuantityL.Location = new System.Drawing.Point(252, 25);
            this.lbQuantityL.Name = "lbQuantityL";
            this.lbQuantityL.Size = new System.Drawing.Size(16, 13);
            this.lbQuantityL.TabIndex = 7;
            this.lbQuantityL.Text = "л.";
            // 
            // lbCurrency2
            // 
            this.lbCurrency2.AutoSize = true;
            this.lbCurrency2.Location = new System.Drawing.Point(252, 65);
            this.lbCurrency2.Name = "lbCurrency2";
            this.lbCurrency2.Size = new System.Drawing.Size(27, 13);
            this.lbCurrency2.TabIndex = 6;
            this.lbCurrency2.Text = "руб.";
            // 
            // tbSumForFuel
            // 
            this.tbSumForFuel.Enabled = false;
            this.tbSumForFuel.Location = new System.Drawing.Point(117, 58);
            this.tbSumForFuel.Name = "tbSumForFuel";
            this.tbSumForFuel.Size = new System.Drawing.Size(129, 20);
            this.tbSumForFuel.TabIndex = 3;
            this.tbSumForFuel.Tag = "radSumForFuel";
            this.tbSumForFuel.Text = "0";
            this.tbSumForFuel.TextChanged += new System.EventHandler(this.tbSumForFuel_TextChanged);
            this.tbSumForFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumForFuel_KeyPress);
            // 
            // tbQuantityFuel
            // 
            this.tbQuantityFuel.Enabled = false;
            this.tbQuantityFuel.Location = new System.Drawing.Point(117, 21);
            this.tbQuantityFuel.Name = "tbQuantityFuel";
            this.tbQuantityFuel.Size = new System.Drawing.Size(129, 20);
            this.tbQuantityFuel.TabIndex = 2;
            this.tbQuantityFuel.Tag = "radQuantityFul";
            this.tbQuantityFuel.Text = "0";
            this.tbQuantityFuel.TextChanged += new System.EventHandler(this.tbQuantityFuel_TextChanged);
            this.tbQuantityFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantityFuel_KeyPress);
            // 
            // radSumForFuel
            // 
            this.radSumForFuel.AutoSize = true;
            this.radSumForFuel.Location = new System.Drawing.Point(15, 58);
            this.radSumForFuel.Name = "radSumForFuel";
            this.radSumForFuel.Size = new System.Drawing.Size(59, 17);
            this.radSumForFuel.TabIndex = 1;
            this.radSumForFuel.Tag = "tbSumForFuel";
            this.radSumForFuel.Text = "Сумма";
            this.radSumForFuel.UseVisualStyleBackColor = true;
            this.radSumForFuel.CheckedChanged += new System.EventHandler(this.radSumForFuel_CheckedChanged);
            // 
            // radQuantityFul
            // 
            this.radQuantityFul.AutoSize = true;
            this.radQuantityFul.Location = new System.Drawing.Point(15, 21);
            this.radQuantityFul.Name = "radQuantityFul";
            this.radQuantityFul.Size = new System.Drawing.Size(84, 17);
            this.radQuantityFul.TabIndex = 0;
            this.radQuantityFul.Tag = "tbQuantityFuel";
            this.radQuantityFul.Text = "Количество";
            this.radQuantityFul.UseVisualStyleBackColor = true;
            this.radQuantityFul.CheckedChanged += new System.EventHandler(this.radQuantityFul_CheckedChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(138, 79);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(129, 20);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.Tag = "lbPrice";
            this.tbPrice.Text = "0";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(69, 79);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Tag = "tbPrice";
            this.lbPrice.Text = "Цена";
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(138, 37);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(129, 21);
            this.cmbFuel.TabIndex = 1;
            this.cmbFuel.SelectedIndexChanged += new System.EventHandler(this.cmbFuel_SelectedIndexChanged);
            // 
            // lbFuel
            // 
            this.lbFuel.AutoSize = true;
            this.lbFuel.Location = new System.Drawing.Point(69, 40);
            this.lbFuel.Name = "lbFuel";
            this.lbFuel.Size = new System.Drawing.Size(44, 13);
            this.lbFuel.TabIndex = 0;
            this.lbFuel.Text = "Бензин";
            // 
            // grpCoffee
            // 
            this.grpCoffee.Controls.Add(this.groupBox1);
            this.grpCoffee.Controls.Add(this.lbQuantity);
            this.grpCoffee.Controls.Add(this.tbColaQuantity);
            this.grpCoffee.Controls.Add(this.tbCheeseburgerQuantity);
            this.grpCoffee.Controls.Add(this.tbGamburgerQuantity);
            this.grpCoffee.Controls.Add(this.tbHotDogQauntity);
            this.grpCoffee.Controls.Add(this.lbCurrencyCoffe4);
            this.grpCoffee.Controls.Add(this.lbCurrencyCoffe3);
            this.grpCoffee.Controls.Add(this.lbCurrencyCoffe2);
            this.grpCoffee.Controls.Add(this.lbCurrencyCoffe1);
            this.grpCoffee.Controls.Add(this.tbCola);
            this.grpCoffee.Controls.Add(this.tbCheeseburger);
            this.grpCoffee.Controls.Add(this.tbGamburger);
            this.grpCoffee.Controls.Add(this.tbHotDog);
            this.grpCoffee.Controls.Add(this.lpPrice);
            this.grpCoffee.Controls.Add(this.chkCola);
            this.grpCoffee.Controls.Add(this.chkCheeseburger);
            this.grpCoffee.Controls.Add(this.chkGamburger);
            this.grpCoffee.Controls.Add(this.chkHotDog);
            this.grpCoffee.Location = new System.Drawing.Point(405, 34);
            this.grpCoffee.Name = "grpCoffee";
            this.grpCoffee.Size = new System.Drawing.Size(351, 337);
            this.grpCoffee.TabIndex = 1;
            this.grpCoffee.TabStop = false;
            this.grpCoffee.Text = "Мини-кофе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCurrencyResultCoffe);
            this.groupBox1.Controls.Add(this.tbResultCoffe);
            this.groupBox1.Controls.Add(this.lbRusulCoffe);
            this.groupBox1.Location = new System.Drawing.Point(30, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lbCurrencyResultCoffe
            // 
            this.lbCurrencyResultCoffe.AutoSize = true;
            this.lbCurrencyResultCoffe.Location = new System.Drawing.Point(267, 42);
            this.lbCurrencyResultCoffe.Name = "lbCurrencyResultCoffe";
            this.lbCurrencyResultCoffe.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyResultCoffe.TabIndex = 8;
            this.lbCurrencyResultCoffe.Text = "руб.";
            // 
            // tbResultCoffe
            // 
            this.tbResultCoffe.Location = new System.Drawing.Point(14, 35);
            this.tbResultCoffe.Name = "tbResultCoffe";
            this.tbResultCoffe.ReadOnly = true;
            this.tbResultCoffe.Size = new System.Drawing.Size(247, 20);
            this.tbResultCoffe.TabIndex = 9;
            this.tbResultCoffe.Text = "0";
            // 
            // lbRusulCoffe
            // 
            this.lbRusulCoffe.AutoSize = true;
            this.lbRusulCoffe.Location = new System.Drawing.Point(6, 16);
            this.lbRusulCoffe.Name = "lbRusulCoffe";
            this.lbRusulCoffe.Size = new System.Drawing.Size(52, 13);
            this.lbRusulCoffe.TabIndex = 8;
            this.lbRusulCoffe.Text = "К оплате";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(250, 16);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(66, 13);
            this.lbQuantity.TabIndex = 16;
            this.lbQuantity.Text = "Количество";
            // 
            // tbColaQuantity
            // 
            this.tbColaQuantity.Location = new System.Drawing.Point(235, 125);
            this.tbColaQuantity.Name = "tbColaQuantity";
            this.tbColaQuantity.ReadOnly = true;
            this.tbColaQuantity.Size = new System.Drawing.Size(80, 20);
            this.tbColaQuantity.TabIndex = 15;
            this.tbColaQuantity.Tag = "chkCola";
            this.tbColaQuantity.Text = "0";
            this.tbColaQuantity.TextChanged += new System.EventHandler(this.tbColaQuantity_TextChanged);
            this.tbColaQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbColaQuantity_KeyPress);
            // 
            // tbCheeseburgerQuantity
            // 
            this.tbCheeseburgerQuantity.Location = new System.Drawing.Point(235, 97);
            this.tbCheeseburgerQuantity.Name = "tbCheeseburgerQuantity";
            this.tbCheeseburgerQuantity.ReadOnly = true;
            this.tbCheeseburgerQuantity.Size = new System.Drawing.Size(80, 20);
            this.tbCheeseburgerQuantity.TabIndex = 14;
            this.tbCheeseburgerQuantity.Tag = "chkCheeseburger";
            this.tbCheeseburgerQuantity.Text = "0";
            this.tbCheeseburgerQuantity.TextChanged += new System.EventHandler(this.tbCheeseburgerQuantity_TextChanged);
            this.tbCheeseburgerQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheeseburgerQuantity_KeyPress);
            // 
            // tbGamburgerQuantity
            // 
            this.tbGamburgerQuantity.Location = new System.Drawing.Point(235, 66);
            this.tbGamburgerQuantity.Name = "tbGamburgerQuantity";
            this.tbGamburgerQuantity.ReadOnly = true;
            this.tbGamburgerQuantity.Size = new System.Drawing.Size(80, 20);
            this.tbGamburgerQuantity.TabIndex = 13;
            this.tbGamburgerQuantity.Tag = "chkGamburger";
            this.tbGamburgerQuantity.Text = "0";
            this.tbGamburgerQuantity.TextChanged += new System.EventHandler(this.tbGamburgerQuantity_TextChanged);
            this.tbGamburgerQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGamburgerQuantity_KeyPress);
            // 
            // tbHotDogQauntity
            // 
            this.tbHotDogQauntity.Location = new System.Drawing.Point(235, 40);
            this.tbHotDogQauntity.Name = "tbHotDogQauntity";
            this.tbHotDogQauntity.ReadOnly = true;
            this.tbHotDogQauntity.Size = new System.Drawing.Size(80, 20);
            this.tbHotDogQauntity.TabIndex = 12;
            this.tbHotDogQauntity.Tag = "chkHotDog";
            this.tbHotDogQauntity.Text = "0";
            this.tbHotDogQauntity.TextChanged += new System.EventHandler(this.tbHotDogQauntity_TextChanged);
            this.tbHotDogQauntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHotDogQauntity_KeyPress);
            // 
            // lbCurrencyCoffe4
            // 
            this.lbCurrencyCoffe4.AutoSize = true;
            this.lbCurrencyCoffe4.Location = new System.Drawing.Point(202, 132);
            this.lbCurrencyCoffe4.Name = "lbCurrencyCoffe4";
            this.lbCurrencyCoffe4.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyCoffe4.TabIndex = 11;
            this.lbCurrencyCoffe4.Text = "руб.";
            // 
            // lbCurrencyCoffe3
            // 
            this.lbCurrencyCoffe3.AutoSize = true;
            this.lbCurrencyCoffe3.Location = new System.Drawing.Point(202, 104);
            this.lbCurrencyCoffe3.Name = "lbCurrencyCoffe3";
            this.lbCurrencyCoffe3.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyCoffe3.TabIndex = 10;
            this.lbCurrencyCoffe3.Text = "руб.";
            // 
            // lbCurrencyCoffe2
            // 
            this.lbCurrencyCoffe2.AutoSize = true;
            this.lbCurrencyCoffe2.Location = new System.Drawing.Point(202, 76);
            this.lbCurrencyCoffe2.Name = "lbCurrencyCoffe2";
            this.lbCurrencyCoffe2.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyCoffe2.TabIndex = 9;
            this.lbCurrencyCoffe2.Text = "руб.";
            // 
            // lbCurrencyCoffe1
            // 
            this.lbCurrencyCoffe1.AutoSize = true;
            this.lbCurrencyCoffe1.Location = new System.Drawing.Point(202, 48);
            this.lbCurrencyCoffe1.Name = "lbCurrencyCoffe1";
            this.lbCurrencyCoffe1.Size = new System.Drawing.Size(27, 13);
            this.lbCurrencyCoffe1.TabIndex = 7;
            this.lbCurrencyCoffe1.Text = "руб.";
            // 
            // tbCola
            // 
            this.tbCola.Location = new System.Drawing.Point(116, 125);
            this.tbCola.Name = "tbCola";
            this.tbCola.ReadOnly = true;
            this.tbCola.Size = new System.Drawing.Size(80, 20);
            this.tbCola.TabIndex = 8;
            this.tbCola.Text = "300";
            this.tbCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCheeseburger
            // 
            this.tbCheeseburger.Location = new System.Drawing.Point(116, 97);
            this.tbCheeseburger.Name = "tbCheeseburger";
            this.tbCheeseburger.ReadOnly = true;
            this.tbCheeseburger.Size = new System.Drawing.Size(80, 20);
            this.tbCheeseburger.TabIndex = 7;
            this.tbCheeseburger.Text = "1200";
            this.tbCheeseburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGamburger
            // 
            this.tbGamburger.Location = new System.Drawing.Point(116, 69);
            this.tbGamburger.Name = "tbGamburger";
            this.tbGamburger.ReadOnly = true;
            this.tbGamburger.Size = new System.Drawing.Size(80, 20);
            this.tbGamburger.TabIndex = 6;
            this.tbGamburger.Text = "1000";
            this.tbGamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHotDog
            // 
            this.tbHotDog.Location = new System.Drawing.Point(116, 41);
            this.tbHotDog.Name = "tbHotDog";
            this.tbHotDog.ReadOnly = true;
            this.tbHotDog.Size = new System.Drawing.Size(80, 20);
            this.tbHotDog.TabIndex = 5;
            this.tbHotDog.Text = "500";
            this.tbHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lpPrice
            // 
            this.lpPrice.AutoSize = true;
            this.lpPrice.Location = new System.Drawing.Point(168, 16);
            this.lpPrice.Name = "lpPrice";
            this.lpPrice.Size = new System.Drawing.Size(33, 13);
            this.lpPrice.TabIndex = 4;
            this.lpPrice.Text = "Цена";
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Location = new System.Drawing.Point(15, 128);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(75, 17);
            this.chkCola.TabIndex = 3;
            this.chkCola.Text = "Coca-Cola";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.chkCola_CheckedChanged);
            // 
            // chkCheeseburger
            // 
            this.chkCheeseburger.AutoSize = true;
            this.chkCheeseburger.Location = new System.Drawing.Point(15, 100);
            this.chkCheeseburger.Name = "chkCheeseburger";
            this.chkCheeseburger.Size = new System.Drawing.Size(78, 17);
            this.chkCheeseburger.TabIndex = 2;
            this.chkCheeseburger.Text = "Гизбургер";
            this.chkCheeseburger.UseVisualStyleBackColor = true;
            this.chkCheeseburger.CheckedChanged += new System.EventHandler(this.chkCheeseburger_CheckedChanged);
            // 
            // chkGamburger
            // 
            this.chkGamburger.AutoSize = true;
            this.chkGamburger.Location = new System.Drawing.Point(15, 72);
            this.chkGamburger.Name = "chkGamburger";
            this.chkGamburger.Size = new System.Drawing.Size(80, 17);
            this.chkGamburger.TabIndex = 1;
            this.chkGamburger.Tag = "tbGamburgerQuantity";
            this.chkGamburger.Text = "Гамбургер";
            this.chkGamburger.UseVisualStyleBackColor = true;
            this.chkGamburger.CheckedChanged += new System.EventHandler(this.chkGamburger_CheckedChanged);
            // 
            // chkHotDog
            // 
            this.chkHotDog.AutoSize = true;
            this.chkHotDog.Location = new System.Drawing.Point(15, 44);
            this.chkHotDog.Name = "chkHotDog";
            this.chkHotDog.Size = new System.Drawing.Size(67, 17);
            this.chkHotDog.TabIndex = 0;
            this.chkHotDog.Tag = "tbHotDogQauntity";
            this.chkHotDog.Text = "Хот-Дог";
            this.chkHotDog.UseVisualStyleBackColor = true;
            this.chkHotDog.CheckedChanged += new System.EventHandler(this.chkHotDog_CheckedChanged);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Image = global::Refill.Properties.Resources.icon_calculator;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(142, 411);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(233, 50);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Рассчитать";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(397, 425);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(43, 13);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Итого: ";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(449, 422);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(272, 20);
            this.tbResult.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.grpCoffee);
            this.Controls.Add(this.grpFuel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Refill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFuel.ResumeLayout(false);
            this.grpFuel.PerformLayout();
            this.grpResultFuel.ResumeLayout(false);
            this.grpResultFuel.PerformLayout();
            this.grpQuantityFuel.ResumeLayout(false);
            this.grpQuantityFuel.PerformLayout();
            this.grpCoffee.ResumeLayout(false);
            this.grpCoffee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuel;
        private System.Windows.Forms.GroupBox grpCoffee;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.Label lbFuel;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox grpQuantityFuel;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSumForFuel;
        private System.Windows.Forms.TextBox tbQuantityFuel;
        private System.Windows.Forms.RadioButton radSumForFuel;
        private System.Windows.Forms.RadioButton radQuantityFul;
        private System.Windows.Forms.Label lbCurrency1;
        private System.Windows.Forms.Label lbQuantityL;
        private System.Windows.Forms.Label lbCurrency2;
        private System.Windows.Forms.GroupBox grpResultFuel;
        private System.Windows.Forms.TextBox tbResultFuel;
        private System.Windows.Forms.Label lbResultFuel;
        private System.Windows.Forms.Label lbCurrencyResult;
        private System.Windows.Forms.TextBox tbCola;
        private System.Windows.Forms.TextBox tbCheeseburger;
        private System.Windows.Forms.TextBox tbGamburger;
        private System.Windows.Forms.TextBox tbHotDog;
        private System.Windows.Forms.Label lpPrice;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkCheeseburger;
        private System.Windows.Forms.CheckBox chkGamburger;
        private System.Windows.Forms.CheckBox chkHotDog;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbColaQuantity;
        private System.Windows.Forms.TextBox tbCheeseburgerQuantity;
        private System.Windows.Forms.TextBox tbGamburgerQuantity;
        private System.Windows.Forms.TextBox tbHotDogQauntity;
        private System.Windows.Forms.Label lbCurrencyCoffe4;
        private System.Windows.Forms.Label lbCurrencyCoffe3;
        private System.Windows.Forms.Label lbCurrencyCoffe2;
        private System.Windows.Forms.Label lbCurrencyCoffe1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCurrencyResultCoffe;
        private System.Windows.Forms.TextBox tbResultCoffe;
        private System.Windows.Forms.Label lbRusulCoffe;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

