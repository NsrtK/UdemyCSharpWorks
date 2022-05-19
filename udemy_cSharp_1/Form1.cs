namespace udemy_cSharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String AddToCartLbl, RemoveFCartlbl, AddToCartbtn, RemFCartbtn;
            AddToCartLbl = "�r�nler";
            RemoveFCartlbl = "Sepet";
            AddToCartbtn = "Sepete Ekle";
            RemFCartbtn = "Sepetten ��kar";

            lblProducts.Text = AddToCartLbl;
            lblCart.Text = RemoveFCartlbl;
            btnAddToCart.Text = AddToCartbtn;
            btnRemoveFromCart.Text = RemFCartbtn;

             string[] pro = new string[] { "Kedi", "K�pek", "�guana" };

            foreach (var item in pro)
            {
                lbxProducts.Items.Add(item.ToString());
            }



    }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("L�tfen bir pet se�iniz");

            
            }

            
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("L�tfen bir pet se�iniz");


            }
        }
    }
}