namespace lab4._44
{
    public partial class Form1 : Form
    {
        coffeemachine coffeemachine;
        public Form1()
        {
            InitializeComponent();
            coffeemachine = new coffeemachine();
        }

        private void buttonchoco_Click(object sender, EventArgs e)  //ปุ่มช็อคโกแลต
        {
            bool canmake = coffeemachine.makechocolate();
            if (canmake)
            {
                picturecoffee.Image = Properties.Resources.ช็อคค;
                MessageBox.Show("ท่านเลือกซื้อช็อคโกแลต โปรดรอรับสินค้าซักครู่");
            }
            else
            {

                MessageBox.Show("ขออภัยส่วนผสมช็อคโกแลตไม่เพียงพอ");

            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }






        private void buttoncoffee_Click_1(object sender, EventArgs e) // กาแฟนิว
        {

            bool canmake = coffeemachine.makecoffee();
            if (canmake)
            {
                picturecoffee.Image = Properties.Resources.กาแฟ;
                MessageBox.Show("ท่านเลือกซื้อกาแฟดำ โปรดรอรับสินค้าซักครู่");
            }
            else
            {

                MessageBox.Show("ขออภัยส่วนผสมกาแฟดำไม่เพียงพอ");

            }
        }

        private void buttonLattle_Click(object sender, EventArgs e)  //ลาเต้นิว
        {
            bool canmake = coffeemachine.makeLatte();
            if (canmake)
            {
                picturecoffee.Image = Properties.Resources.ลาเต้;
                MessageBox.Show("ท่านเลือกซื้อลาเต้ โปรดรอรับสินค้าซักครู่");
            }
            else
            {

                MessageBox.Show("ขออภัยส่วนผสมลาเต้ไม่เพียงพอ");

            }
        }

        private void buttonmocha_Click(object sender, EventArgs e) //ม็อคค่า
        {
            bool canmake = coffeemachine.makemocha();
            if (canmake)
            {
                picturecoffee.Image = Properties.Resources.download;
                MessageBox.Show("ท่านเลือกซื้อม็อคค่า โปรดรอรับสินค้าซักครู่");
            }
            else
            {

                MessageBox.Show("ขออภัยส่วนผสมม็อคค่าไม่เพียงพอ");

            }
        }

        private void Replenish_Click(object sender, EventArgs e) //เติมสินค้า
        {
            bool canmake = coffeemachine.Replenish();
            if (canmake)
            {
                picturecoffee.Image = Properties.Resources.suc;
                MessageBox.Show("เติมสินค้าเรียบร้อยแล้ว");
            }
            else
            {

                MessageBox.Show("ขออภัยส่วนผสมมีพออยู่แล้ว");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

