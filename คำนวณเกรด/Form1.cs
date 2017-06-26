using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace คำนวณเกรด
{
    public partial class Form1 : Form
    {
        double Grade;
        public Form1()
        {
            InitializeComponent();
        }            
        private void button1_Click_1(object sender, EventArgs e)
        {
            try//ตรวจจับError
            {
                label23.Text = textBox1.Text;//แสดงรหัสนักศึกจากการป้อนข้อมูลจากTextbox1
                label24.Text = textBox2.Text;//แสดงชื่อ-นามสุกลนักศึกษาขากากรป้อนข้อมูลTextbox2
                string G = textBox3.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox3
                string G1 = textBox4.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox4
                string G2 = textBox5.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox4
                string G3 = textBox6.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox4
                string G4 = textBox7.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox4
                string G5 = textBox8.Text;//เก็บค่าตัวแปรโดยรับจากการใส่ตัวอักษรในtextbox4
                switch (G)//คำสั่งSwicth....case 
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext3 และนำมาเก็บใน G และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3 
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;//C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double A = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G)
                switch (G1)//คำสั่งSwicth....case 
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext4 และนำมาเก็บใน G1 และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3 
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;// C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double B = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G1)
                switch (G2)//คำสั่งSwicth.....case
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext5 และนำมาเก็บใน G2 และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;// C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double C = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G2)
                switch (G3)//คำสั่งSwicth.....case
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext6 และนำมาเก็บใน G3 และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;// C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double D = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G3)
                switch (G4)//คำสั่งSwicth.......case
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext7 และนำมาเก็บใน G4 และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;// C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double E = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G4)

                switch (G5)//คำสั่งSwicth.....case
                {
                    case "A": Grade = 4 * 3; break;//กรณีใส่ค่าตัวแปรในtext8 และนำมาเก็บใน G5 และถ้าเป็น A แสดงเป็น4*3คือ A=เกรด4 คูณหน่วยกิต 3
                    case "B+": Grade = 3.5 * 3; break;//กรณีค่ากับ A แต่จะเปลี่ยนเป็น B+ B+คือเกรด3.5 คูณหน่วยกิต3
                    case "B": Grade = 3 * 3; break;// Bคือเกรด3 คูณหน่วยกิต3
                    case "C+": Grade = 2.5 * 3; break;//C+ คือเกรด2.5 คูณหน่วยกิต3
                    case "C": Grade = 2 * 3; break;// C คือเกรด2 คูณหน่วยกิต3
                    case "D+": Grade = 1.5 * 3; break;//D+ คือเกรด1.5 คูณหน่วยกิต3
                    case "D": Grade = 1 * 3; break;//D คือเกรด1 คูณหน่วยกิต3
                    case "F": Grade = 0; break;//F คือเกรด 0 จะไม่คูนเพราะ0คูณอะไรก็ได้0
                }
                double F = Grade;//กำหนดค่าตัวแปรให้เก็บค่าตัวแปรจากSwitch(G4)
                double X = (A + B + C + D + E + F) / 18;//หลังจากรับค่าตัวแปร double จากการเก็ยSwicth...case ทุกตัวที่เก็บค่าตัวแปรของแต่ล่ะข้อให้มาบวกกันและหานด้วย18 คือหน่วยกิตรวม
                label22.Text = X.ToString("#.##");//ให้ label22 แสดงค่าของ double x เมื่อคำนวณเสร็จแปลงเป็นString และกำหนดทศนิยมโดยใช้("#.##")

                int Fa = 0;//กำหนดให้ FA = 0
                int pa = 0;//กำหนดให้ pa = 0
                int Fail = 3;//กำหนดให้ Fail = 0
                int pass = 18;//กำหนดให้ pass = 18
                if (G == "F")//ถ้าเกิด G = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18-3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G != "F")//ถ้าเกิด G ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดง Pa คือจำนวนที่ Fa + Pa หรือ 0+0
                }
                if (G1 == "F")//ถ้าเกิด G1 = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();// label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18 - 3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G1 != "F")//ถ้าเกิด G1 ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดง Pa คือจำนวนที่ Fa + Pa หรือ 0+0
                }
                if (G2 == "F")//ถ้าเกิด G2 = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();// label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18 - 3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G2 != "F")//ถ้าเกิด G2 ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดง Pa คือจำนวนที่ Fa + Pa หรือ 0+0
                }
                if (G3 == "F")//ถ้าเกิด G3 = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();// label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18 - 3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G3 != "F")//ถ้าเกิด G3 ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0
                }
                if (G4 == "F")//ถ้าเกิด G4 = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();// label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18 - 3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G4 != "F")//ถ้าเกิด G4 ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0
                }
                if (G5 == "F")//ถ้าเกิด G5 = F จะแสเดงค่าต่อไปนี้
                {
                    pass -= Fail;//pass จะถูกลบออกด้วย Fail 18-3
                    label25.Text = pass.ToString();// label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Fail หรือ 18 - 3

                    Fa += Fail;//Fa จะถูกเพิ่มด้วย Fail คือ 0+3
                    label26.Text = Fa.ToString();//label26 แทนด้วยหน่วยกิตที่ไม่ผ่านให้แสดงFa คือจำนวนที่ Fa + Fail หรือ 0+3
                }
                else if (G5 != "F")//ถ้าเกิด G5 ไม่เท่ากับ F จะแสเดงค่าต่อไปนี้
                {
                    pass -= pa;// pass จะถูกลบออกด้วย Pa 18 - 0
                    label25.Text = pass.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0

                    Fa += pa;//Fa จะถูกเพิ่มด้วย Pa คือ 0+0
                    label26.Text = Fa.ToString();//label25 แทนด้วยหน่วยกิตที่ผ่านให้แสดงpass คือจำนวนที่ pass - Pa หรือ 18-0
                }
            }
            catch
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";//ล้าง Text1
            textBox2.Text = "";//ล้าง Text2
            textBox3.Text = "";//ล้าง Text3
            textBox4.Text = "";//ล้าง Text4
            textBox5.Text = "";//ล้าง Text5
            textBox6.Text = "";//ล้าง Text6
            textBox7.Text = "";//ล้าง Text7
            textBox8.Text = "";//ล้าง Text8
            label22.Text = "";//ล้าง label22
            label25.Text = "";//ล้าง label25
            label26.Text = "";//ล้าง label26
            label23.Text = "";//ล้าง label23
            label24.Text = "";//ล้าง label24
        }
    }
}
