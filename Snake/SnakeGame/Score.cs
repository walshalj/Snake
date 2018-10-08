using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

      

        //read scores 
        public void m_readScores()
        {            
            txtBox_Scores.Text = System.IO.File.ReadAllText( "Scores.txt");
                          
        }



        private void frm_Scores_Load(object sender, EventArgs e)
        {
           m_readScores();
           txtBox_Scores.Enabled = true;         
        }
    }
}
