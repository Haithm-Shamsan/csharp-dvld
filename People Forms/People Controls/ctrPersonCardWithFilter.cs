using DVLD_BussnisLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
        }
        
       public int PersonID
        {
            get
            {
                return ctrPersonCard1._PersonID;
            }
        }

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int personID)
        {
            Action<int> handler= OnPersonSelected;
            if (handler != null)
            {
               handler(personID);
            }
        }


        public void LoadUserInfo(int PersonInfo)
        {
         
           if(OnPersonSelected!=null)
                OnPersonSelected(PersonInfo);
            ctrPersonCard1.LoadPersonInfo( PersonInfo);
        }
        private void ctrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
           
        }
        private void cmbFilterBy()
        {
            DataView Search = clsPeople.GetPeople().DefaultView;
            txtSearch.Visible = true;
            switch (cmbSearchBy.SelectedItem)
            {

                case "None":
                    txtSearch.Visible = false;
                  
                    break;

                case "PersonID":
                    
                    ctrPersonCard1.LoadPersonInfo(int.Parse(txtSearch.Text));
                   
                   
                    break;

                case "NationalNo":
                    
                    ctrPersonCard1.LoadPersonInfo(txtSearch.Text);
                   
                    break;
                default:
                   
                    break;

                
            }
          
 
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           cmbFilterBy();
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditAddNewPerson frm = new frmEditAddNewPerson(-1);
            frmEditAddNewPerson.DataBack += DataBack;
            frm.ShowDialog();
        }

        void DataBack(object sender,int PersonId)
        {
            
           
            ctrPersonCard1.LoadPersonInfo(PersonId);
         

        }

        private void ctrPersonCard1_Load(object sender, EventArgs e)
        {

         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
