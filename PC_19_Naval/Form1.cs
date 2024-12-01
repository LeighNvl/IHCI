using System.Runtime.CompilerServices;

namespace PC_19_Naval
{
    public partial class rdoWhereIn : Form
    {
        public rdoWhereIn()
        {
            InitializeComponent();
            myPizza = new Pizza();
            this.Load += new EventHandler(frmPizza_Load);

        }
        Pizza myPizza;
        CheckBox[] topping = new CheckBox[6];
        bool loading = true;

        private void frmPizza_Load(object sender, EventArgs e)
        {
            myPizza = new Pizza();
            topping[0] = chkCheese;
            topping[1] = chkMushroom;
            topping[2] = chkOlives;
            topping[3] = chkOnions;
            topping[4] = chkPeppers;
            topping[5] = chkTomatoes;
            loading = false;
        }

        private void rdoSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaSize = ((RadioButton)sender).Text; }
        }

        private void rdoSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaSize = ((RadioButton)sender).Text; }
        }

        private void rdoSizelarge_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaSize = ((RadioButton)sender).Text; }
        }

        private void rdoCrustThick_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaCrust = ((RadioButton)sender).Text; }
        }

        private void rdoCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaCrust = ((RadioButton)sender).Text; }
        }

        private void rdoWhereOut_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaWhere = ((RadioButton)sender).Text; }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            { myPizza.PizzaWhere = ((RadioButton)sender).Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (topping[i].Checked)
                {
                    myPizza.PizzaTopping[i] = topping[i].Text;
                }
                else
                {
                    myPizza.PizzaTopping[i] = "";
                }
            }
            MessageBox.Show(myPizza.DescribePizza(), "Your Pizza", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal class Pizza
        {
            public string PizzaSize { get; internal set; }
            public string PizzaCrust { get; internal set; }
            public string PizzaWhere { get; internal set; }
            public string[] PizzaTopping = new string[6];

            public string DescribePizza()
            {
                return PizzaWhere  + "\n" + PizzaCrust + "\n" + PizzaSize + "\n" + "\n" + "Toppings:" + "\n" + DisplayToppings();
            }
            public string DisplayToppings()
            {
                string toppings = "";
                for (int i = 0; i < PizzaTopping.Length; i++)
                {
                    if (!string.IsNullOrEmpty(PizzaTopping[i]))
                    {
                        toppings += PizzaTopping[i] + "\n";
                    }
                }
                return toppings;
            }
        }
    }
}
