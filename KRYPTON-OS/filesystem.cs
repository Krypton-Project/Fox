/** Copyright 
 * (c) Edward Chernysh (kryptonX)
 * 
    *This program is free software: you can redistribute it and/or modify
    *it under the terms of the GNU General Public License as published by
    *the Free Software Foundation, either version 3 of the License, or
    *(at your option) any later version.

    *This program is distributed in the hope that it will be useful,
    *but WITHOUT ANY WARRANTY; without even the implied warranty of
    *MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    *GNU General Public License for more details.

    *You should have received a copy of the GNU General Public License
    *along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
  **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace krypto_os
{
    public partial class filesystem : Form
    {
        int a = 1;
        int b = 2;
        int c = 3;
        root root2 = new root();
//----------------------------------------------------------------------------------------------------------------------
       
        private int childFormNumber = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
/// <summary>
/// start of FILESYSTEM CREATION[bin]------------------------------------------------------------------------------------
/// </summary>
        Form fileView = new Form();
        RichTextBox fileText = new RichTextBox();
       
        //TextBox & Panel for C++ Framework
        Panel cplusPanel = new Panel();
        RichTextBox cplusText = new RichTextBox();
        //----------------------------------------

        //TextBox & Panel for Viewing X++ Framework
        Panel xplusPanel = new Panel();
        RichTextBox xPlusText = new RichTextBox();
        //---------------------------------------

        //TextBox & Panel for Viewing KSX Framework: root\bin\KSX
        Panel ksxPanel = new Panel();
        RichTextBox ksxText = new RichTextBox();
        //--------------------------------------

        //TextBox & Panel for Viewing K Framework: root\bin\k
        Panel kPanel = new Panel();
        RichTextBox kText = new RichTextBox();
        //----------------------------------------

        //TextBox & Panel for Viewing bz2 compression/decompression Framework: root\bin\bz2
        Panel bz2Panel = new Panel();
        RichTextBox bz2Text = new RichTextBox();
        //----------------------------------------
        
        //TextBox & Panel for gzip functions and variable: root\bin\gzip
        Panel gzipPanel = new Panel();
        RichTextBox gzipText = new RichTextBox();
        //----------------------------------------

        //TextBox & Panel for proxy_specs Framework: root\bin\proxy_specs
        Panel proxyPanel = new Panel();
        RichTextBox proxyText = new RichTextBox();
        //----------------------------------------

        //TextBox & Panel for X10 Framework:  root\bin\X10
        Panel x10Panel = new Panel();
        RichTextBox x10Text = new RichTextBox();
        //----------------------------------------  
    
       
/// <summary>
/// Beginning of filesystem creation [core system]----------------------------------------------------------------------------
/// </summary>

        //TextBox & Panel for quadrent_1: root\core system\quadrent_1
        Panel quadrent1Panel = new Panel();
        RichTextBox quadrent1Text = new RichTextBox();
        //---------------------------------------------

        //TextBox & Panel for bootargs: root\core system\bootargs
        Panel bootargsPanel = new Panel();
        RichTextBox bootargstext = new RichTextBox();
        //--------------------------------------------

        //TextBox & Panel for system services: root\core system\system services
        Panel systemservicesPanel = new Panel();
        RichTextBox systemservicesText = new RichTextBox();
        //----------------------------------------------

        //TextBox & Panel for TERMINAL SERVICES: root\core system\TERMINAL
        Panel terminalPanel = new Panel();
        RichTextBox terminalText = new RichTextBox();
        //----------------------------------------------

/// <summary>
///  End of FileSystem Creation [core system]-------------------------------------------------------------------------------
/// </summary>


/// <summary>
/// Start of Filesystem Creation [dev]-------------------------------------------------------------------------------------
/// </summary>

       //TextBox & Panel for CONSOLE DATA: root\dev\console
        Panel consolePanel = new Panel();
        RichTextBox consoleText = new RichTextBox();
        //-------------------------------------------------------
        
/// <summary>
/// END OF Filesystem Creation [dev]-------------------------------------------------------------------------------------
/// </summary>

///<summary>
/// Start Of Filesystem Creation [Library]--------------------------------------------------------------------------------
///</summary>

        //TextBox & Panel for FORMAT: root\library\format
        Panel formatPanel = new Panel();
        RichTextBox formatText = new RichTextBox();
        //------------------------------------------------------------------------------------------------------

     //----------------------------------PANEL FOR SUB-CLUB PANEL
        Panel clubPanel = new Panel();
        RichTextBox clubText = new RichTextBox();
        //-----------------------------------------------
        
        //-------------------------------Panel for GUI\LISTVIEW
        Panel listviewPanel = new Panel();
        //---------------------------------------------------

        //Panel for Update Folder:
        Panel updatePanel = new Panel();
        //--------------------------------------------------

        //Panel for kernel info folder
        Panel kernelPanel = new Panel();
        //--------------------------------------------------

        //Panel for X interface
        Panel xiPanel = new Panel();
        //-------------------------------------------------

        //--------------------------------------------------------------------------------------------------------

        //Panel for tmp (downloads)
        Panel tmpPanel = new Panel();
        //-----------------------------------------------------------------------------

        public filesystem()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();               
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }

          
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void filesystem_Load(object sender, EventArgs e)
        {
            
            
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appPanel.Visible = true;
            appPanel.Dock = DockStyle.Fill;
            appPanel.BringToFront();

            
        }

        private void button4_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            (new phantom()).Show(panel1);
        }

        private void button5_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void panel1_StyleChanged(object sender, EventArgs e)
        {
            (new phantom()).ShowDialog();
            
            
        }

        private void phantom_k_Click(object sender, EventArgs e)
        {
            (new phantom()).ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bash.bashGUI.BASH();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (appPanel.Visible == true)
            {
                appPanel.Visible = false;
            }
            else
            {
                if (coresystemPanel.Visible == true)
                {
                    if (coresystemPanel.Controls.Contains(quadrent1Panel))
                    {
                        quadrent1Panel.Visible = false;
                        coresystemPanel.Controls.Remove(quadrent1Panel);
                        //Sets visibility of the buttons in *core system panel* to true                        
                        button18.Visible = true;
                        bootArgs.Visible = true;
                        systemServicesBtn.Visible = true;
                        servicesTerminal.Visible = true;
                        //END
                    }
                    else
                    {
                        if (coresystemPanel.Controls.Contains(bootargsPanel))
                        {
                            bootargsPanel.Visible = false;
                            coresystemPanel.Controls.Remove(bootargsPanel);
                            //Sets visibility of the buttons in *core system panel* to true
                            button18.Visible = true;
                            bootArgs.Visible = true;
                            systemServicesBtn.Visible = true;
                            servicesTerminal.Visible = true;
                            //END
                        }
                        else
                        {
                            if (coresystemPanel.Controls.Contains(terminalPanel))
                            {
                                terminalPanel.Visible = false;
                                coresystemPanel.Controls.Remove(terminalPanel);
                                //Sets visibility of the buttons in *core system panel* to true
                                button18.Visible = true;
                                bootArgs.Visible = true;
                                systemServicesBtn.Visible = true;
                                servicesTerminal.Visible = true;
                                //END
                            }
                            else
                            {
                                if (coresystemPanel.Controls.Contains(systemservicesPanel))
                                {
                                    systemservicesPanel.Visible = false;
                                    coresystemPanel.Controls.Remove(systemservicesPanel);
                                    //Sets visibility of the buttons in *core system panel* to true
                                    button18.Visible = true;
                                    bootArgs.Visible = true;
                                    systemServicesBtn.Visible = true;
                                    servicesTerminal.Visible = true;
                                    //END
                                }
                                else
                                {
                                    if (coresystemPanel.Visible == true)
                                    {
                                        coresystemPanel.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
                if (libPanel.Visible == true)
                {

                    if (libPanel.Controls.Contains(clubsubPanel))
                    {
                        clubsubPanel.Visible = false;
                        libPanel.Controls.Remove(clubsubPanel);
                        //
                        frmatBtn.Visible = true;
                        guiFolder.Visible = true;
                        clubBtn.Visible = true;
                        xiFolder.Visible = true;
                        updateFolder.Visible = true;
                        kernelFolder.Visible = true;
                        //
                    }
                    else
                    {
                        if (libPanel.Controls.Contains(formatPanel))
                        {
                            formatPanel.Visible = false;
                            libPanel.Controls.Remove(formatPanel);
                            //
                            frmatBtn.Visible = true;
                            guiFolder.Visible = true;
                            clubBtn.Visible = true;
                            xiFolder.Visible = true;
                            updateFolder.Visible = true;
                            kernelFolder.Visible = true;
                            //
                        }
                        else
                        {
                            if (libPanel.Controls.Contains(guiPanel))
                            {
                                guiPanel.Visible = false;
                                libPanel.Controls.Remove(guiPanel);
                                //
                                frmatBtn.Visible = true;
                                guiFolder.Visible = true;
                                clubBtn.Visible = true;
                                xiFolder.Visible = true;
                                updateFolder.Visible = true;
                                kernelFolder.Visible = true;
                                //
                            }
                            else
                            {
                                if (libPanel.Controls.Contains(updatePanel))
                                {
                                    updatePanel.Visible = false;
                                    libPanel.Controls.Remove(updatePanel);
                                    //
                                    frmatBtn.Visible = true;
                                    guiFolder.Visible = true;
                                    clubBtn.Visible = true;
                                    xiFolder.Visible = true;
                                    updateFolder.Visible = true;
                                    kernelFolder.Visible = true;
                                    //
                                }
                                else
                                {
                                    if (this.libPanel.Controls.Contains(kernelPanel))
                                    {
                                        kernelPanel.Visible = false;
                                        this.libPanel.Controls.Remove(kernelPanel);
                                        //
                                        frmatBtn.Visible = true;
                                        guiFolder.Visible = true;
                                        clubBtn.Visible = true;
                                        xiFolder.Visible = true;
                                        updateFolder.Visible = true;
                                        kernelFolder.Visible = true;
                                        //

                                    }
                                    else
                                    {
                                        if (libPanel.Controls.Contains(xiPanel))
                                        {
                                            xiPanel.Visible = false;
                                            libPanel.Controls.Remove(xiPanel);
                                            //
                                            frmatBtn.Visible = true;
                                            guiFolder.Visible = true;
                                            clubBtn.Visible = true;
                                            xiFolder.Visible = true;
                                            updateFolder.Visible = true;
                                            kernelFolder.Visible = true;
                                            //
                                        }
                                        else
                                        {
                                            if (libPanel.Visible == true)
                                            {
                                                libPanel.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (panel1.Controls.Contains(kryptonPanel))
                {
                    kryptonPanel.Visible = false;
                    panel1.Controls.Remove(kryptonPanel);
                }

                if (panel1.Controls.Contains(tmpPanel))
                {
                    tmpPanel.Visible = false;
                    panel1.Controls.Remove(tmpPanel);
                }

               
                if (devPanel.Visible == true)
                {
                    if (devPanel.Controls.Contains(consolePanel))
                    {
                        consolePanel.Visible = false;
                        devPanel.Controls.Remove(consolePanel);
                        //Sets button visible;
                        consoleBtn.Visible = true;

                    }
                    else
                    {
                        if (devPanel.Visible == true)
                        {
                            devPanel.Visible = false;
                        }
                    }
                }
                else
                {

                }
                if (binPanel.Visible == true)
                {
                    if (binPanel.Controls.Contains(cplusPanel))
                    {
                        cplusPanel.Visible = false;
                        binPanel.Controls.Remove(cplusPanel);
                        //Sets the visibility of the buttons in *binPanel* to true
                        cplusFramework.Visible = true;
                        xplusFramework.Visible = true;
                        ksxFramework.Visible = true;
                        kFramework.Visible = true;
                        bZip2.Visible = true;
                        gZip.Visible = true;
                        proxy_specs.Visible = true;
                        X10framework.Visible = true;
                        //ALL BUTTNS ARE VISIBLE
                    }
                    else
                    {
                        if (binPanel.Controls.Contains(xplusPanel))
                        {
                            xplusPanel.Visible = false;
                            binPanel.Controls.Remove(xplusPanel);
                            //Sets the visibility of the buttons in *binPanel* to true
                            cplusFramework.Visible = true;
                            xplusFramework.Visible = true;
                            ksxFramework.Visible = true;
                            kFramework.Visible = true;
                            bZip2.Visible = true;
                            gZip.Visible = true;
                            proxy_specs.Visible = true;
                            X10framework.Visible = true;
                            //ALL BUTTNS ARE VISIBLE
                        }
                        else
                        {
                            if (binPanel.Controls.Contains(ksxPanel))
                            {
                                ksxPanel.Visible = false;
                                binPanel.Controls.Remove(ksxPanel);
                                //Sets the visibility of the buttons in *binPanel* to true
                                cplusFramework.Visible = true;
                                xplusFramework.Visible = true;
                                ksxFramework.Visible = true;
                                kFramework.Visible = true;
                                bZip2.Visible = true;
                                gZip.Visible = true;
                                proxy_specs.Visible = true;
                                X10framework.Visible = true;
                                //ALL BUTTNS ARE VISIBLE
                            }
                            else
                            {
                                if (binPanel.Controls.Contains(kPanel))
                                {
                                    kPanel.Visible = false;
                                    binPanel.Controls.Remove(kPanel);
                                    //Sets the visibility of the buttons in *binPanel* to true
                                    cplusFramework.Visible = true;
                                    xplusFramework.Visible = true;
                                    ksxFramework.Visible = true;
                                    kFramework.Visible = true;
                                    bZip2.Visible = true;
                                    gZip.Visible = true;
                                    proxy_specs.Visible = true;
                                    X10framework.Visible = true;
                                    //ALL BUTTNS ARE VISIBLE

                                }
                                else
                                {
                                    if (binPanel.Controls.Contains(bz2Panel))
                                    {
                                        bz2Panel.Visible = false;
                                        binPanel.Controls.Remove(bz2Panel);
                                        //Sets the visibility of the buttons in *binPanel* to true
                                        cplusFramework.Visible = true;
                                        xplusFramework.Visible = true;
                                        ksxFramework.Visible = true;
                                        kFramework.Visible = true;
                                        bZip2.Visible = true;
                                        gZip.Visible = true;
                                        proxy_specs.Visible = true;
                                        X10framework.Visible = true;
                                        //ALL BUTTNS ARE VISIBLE

                                    }
                                    else
                                    {
                                        if (binPanel.Controls.Contains(proxyPanel))
                                        {
                                            proxyPanel.Visible = false;
                                            binPanel.Controls.Remove(proxyPanel);
                                            //Sets the visibility of the buttons in *binPanel* to true
                                            cplusFramework.Visible = true;
                                            xplusFramework.Visible = true;
                                            ksxFramework.Visible = true;
                                            kFramework.Visible = true;
                                            bZip2.Visible = true;
                                            gZip.Visible = true;
                                            proxy_specs.Visible = true;
                                            X10framework.Visible = true;
                                            //ALL BUTTNS ARE VISIBLE
                                        }
                                        else
                                        {

                                            if (binPanel.Controls.Contains(gzipPanel))
                                            {
                                                gzipPanel.Visible = false;
                                                binPanel.Controls.Remove(gzipPanel);
                                                //Sets the visibility of the buttons in *binPanel* to true
                                                cplusFramework.Visible = true;
                                                xplusFramework.Visible = true;
                                                ksxFramework.Visible = true;
                                                kFramework.Visible = true;
                                                bZip2.Visible = true;
                                                gZip.Visible = true;
                                                proxy_specs.Visible = true;
                                                X10framework.Visible = true;
                                                //ALL BUTTNS ARE VISIBLE
                                            }
                                            else
                                            {
                                                if (binPanel.Controls.Contains(x10Panel))
                                                {
                                                    x10Panel.Visible = false;
                                                    binPanel.Controls.Remove(x10Panel);
                                                    //Sets the visibility of the buttons in *binPanel* to true
                                                    cplusFramework.Visible = true;
                                                    xplusFramework.Visible = true;
                                                    ksxFramework.Visible = true;
                                                    kFramework.Visible = true;
                                                    bZip2.Visible = true;
                                                    gZip.Visible = true;
                                                    proxy_specs.Visible = true;
                                                    X10framework.Visible = true;
                                                    //ALL BUTTNS ARE VISIBLE
                                                }
                                                else
                                                {
                                                    if (binPanel.Visible == true)
                                                    {
                                                        binPanel.Visible = false;
                                                    }
                                                    else
                                                    {
                                                                                                                                                                       


                                                    }

                                                }

                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            bash.bashGUI.BASH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            binPanel.Dock = DockStyle.Fill;
            binPanel.BringToFront();
            binPanel.Visible = true;
        }

        private void cFramework_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            binPanel.Controls.Add(cplusPanel);
            cplusPanel.Dock = DockStyle.Fill;
            cplusPanel.Controls.Add(cplusText);
            cplusPanel.Visible = true;
            cplusText.Dock = DockStyle.Fill;
            cplusText.ReadOnly = true;
            cplusText.Text = "/**The C language in the most basic form**/\n\" 0x0s564s6 + 0x1545s\r\"0x454s54_46sdaf79f4wef1wef1f31sd3f46we6tw676w7twe8t737768756645635414667434661w4664w43t1q64g6344563a43a34644564454s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f34s54_46sdaf79f4wef1wef1f3";
            cplusPanel.BringToFront();
            cplusText.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE

        }

        private void xplusFramework_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(xplusPanel);
            xplusPanel.Dock = DockStyle.Fill;
            xplusPanel.Controls.Add(xPlusText);
            xplusPanel.Visible = true;
            xPlusText.Dock = DockStyle.Fill;
            xPlusText.ReadOnly = true;            
            xPlusText.Text = "5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f16RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1D6F465SD5F1 6S46VF4W6RW6EV4R16WE0sdfsdds3f1";
            xplusPanel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
            
        }

        private void ksxFramework_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(ksxPanel);
            ksxPanel.Dock = DockStyle.Fill;
            ksxPanel.Controls.Add(ksxText);
            ksxPanel.Visible = true;
            ksxText.Dock = DockStyle.Fill;
            ksxText.ReadOnly = true;
            ksxText.Text = "ÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàv";
            ksxPanel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
            

        }

        private void kFramework_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(kPanel);
            kPanel.Dock = DockStyle.Fill;
            kPanel.Controls.Add(kText);
            kPanel.Visible = true;
            kText.Dock = DockStyle.Fill;
            kText.ReadOnly = true;
            kText.Text = "000000ÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþàÎúíþà 1s46ada6f164e16faw416e416aw4efwa614ea61af6 46v 6df46sdf4sd6f /*/*/*/*";
            kPanel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
        }

        private void bZip2_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(bz2Panel);
            bz2Panel.Dock = DockStyle.Fill;
            bz2Panel.Controls.Add(bz2Text);
            bz2Panel.Visible = true;
            bz2Text.ReadOnly = true;
            bz2Text.Dock = DockStyle.Fill;
            bz2Text.Text = "B8?@^*&((&%*%(~~~";
            bz2Panel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
        }

        private void gZip_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(gzipPanel);
            gzipPanel.Dock = DockStyle.Fill;
            gzipPanel.Controls.Add(gzipText);
            gzipPanel.Visible = true;
            gzipText.ReadOnly = true;
            gzipText.Dock = DockStyle.Fill;
            gzipText.Text = "%^**^?";
            gzipPanel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
        }

        private void proxy_specs_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(proxyPanel);
            proxyPanel.Dock = DockStyle.Fill;
            proxyPanel.Controls.Add(proxyText);
            proxyPanel.Visible = true;
            proxyText.ReadOnly = true;
            proxyText.Dock = DockStyle.Fill;
            proxyText.Text = "_|=\\|+-*[]?";
            proxyPanel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE
        }

        private void X10framework_Click(object sender, EventArgs e)
        {
            binPanel.Controls.Add(x10Panel);
            x10Panel.Dock = DockStyle.Fill;
            x10Panel.Controls.Add(x10Text);
            x10Panel.Visible = true;
            x10Text.ReadOnly = true;
            x10Text.Dock = DockStyle.Fill;
            x10Text.Text = "*[]";
            x10Panel.BringToFront();
            //Sets the visibility of the buttons in *binPanel* to false
            cplusFramework.Visible = false;
            xplusFramework.Visible = false;
            ksxFramework.Visible = false;
            kFramework.Visible = false;
            bZip2.Visible = false;
            gZip.Visible = false;
            proxy_specs.Visible = false;
            X10framework.Visible = false;
            //ALL BUTTNS ARE NOT VISIBLE

        }

        private void button18_Click(object sender, EventArgs e)
        {
            coresystemPanel.Controls.Add(quadrent1Panel);
            quadrent1Panel.Dock = DockStyle.Fill;
            quadrent1Panel.Controls.Add(quadrent1Text);
            quadrent1Panel.Visible = true;
            quadrent1Text.ReadOnly = true;
            quadrent1Text.Dock = DockStyle.Fill;
            quadrent1Text.Text = "*-/{19]";
            //Sets visibility of the buttons in *core system panel* to false
            button18.Visible = false;
            bootArgs.Visible = false;
            systemServicesBtn.Visible = false;
            servicesTerminal.Visible = false;
            //END
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coresystemPanel.Visible = true;
            coresystemPanel.BringToFront();
            coresystemPanel.Dock = DockStyle.Fill;
            
            
        }

        private void coresystemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bootArgs_Click(object sender, EventArgs e)
        {
            coresystemPanel.Controls.Add(bootargsPanel);
            bootargsPanel.Dock = DockStyle.Fill;
            bootargsPanel.Controls.Add(bootargstext);
            bootargsPanel.Visible = true;
            bootargstext.ReadOnly = true;
            bootargstext.Dock = DockStyle.Fill;
            bootargstext.Text = "this((boot.args.order[0]).equals(false))";
            //Sets visibility of the buttons in *core system panel* to false
            button18.Visible = false;
            bootArgs.Visible = false;
            systemServicesBtn.Visible = false;
            servicesTerminal.Visible = false;
            //END
        }

        private void systemServicesBtn_Click(object sender, EventArgs e)
        {
            coresystemPanel.Controls.Add(systemservicesPanel);
            systemservicesPanel.Dock = DockStyle.Fill;
            systemservicesPanel.Controls.Add(systemservicesText);
            systemservicesPanel.Visible = true;
            systemservicesText.ReadOnly = true;
            systemservicesText.Dock = DockStyle.Fill;
            systemservicesText.Text = "<enabled>false</enabled\n\"return 0;";
            //Sets visibility of the buttons in *core system panel* to false
            button18.Visible = false;
            bootArgs.Visible = false;
            systemServicesBtn.Visible = false;
            servicesTerminal.Visible = false;
            //END
        }

        private void servicesTerminal_Click(object sender, EventArgs e)
        {
            coresystemPanel.Controls.Add(this.terminalPanel);
            this.terminalPanel.Dock = DockStyle.Fill;
            this.terminalPanel.Controls.Add(this.terminalText);
            this.terminalPanel.Visible = true;
            this.terminalText.ReadOnly = true;
            this.terminalText.Dock = DockStyle.Fill;
            this.terminalText.Text = "using html;\r\"HTML(<a href=root\applications\terminal.k'></a>'";
            //Sets visibility of the buttons in *core system panel* to false
            button18.Visible = false;
            bootArgs.Visible = false;
            systemServicesBtn.Visible = false;
            servicesTerminal.Visible = false;
            //END
            

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            coresystemPanel.Controls.Add(quadrent1Panel);
            quadrent1Panel.Dock = DockStyle.Fill;
            quadrent1Panel.Controls.Add(quadrent1Text);
            quadrent1Panel.Visible = true;
            quadrent1Text.ReadOnly = true;
            quadrent1Text.Dock = DockStyle.Fill;
            quadrent1Text.Text = "*-/{19]";
            //Sets visibility of the buttons in *core system panel* to false
            button18.Visible = false;
            bootArgs.Visible = false;
            systemServicesBtn.Visible = false;
            servicesTerminal.Visible = false;
            //END
        }

        private void coresystemPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void binPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            devPanel.Visible = true;
            devPanel.Dock = DockStyle.Fill;
            devPanel.BringToFront();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            devPanel.Controls.Add(consolePanel);
            consolePanel.BringToFront();
            consolePanel.Dock = DockStyle.Fill;
            consolePanel.Visible = true;
            consolePanel.Controls.Add(consoleText);
            consoleText.Dock = DockStyle.Fill;
            consoleText.ReadOnly = true;
            consoleText.Text = "10100100101010010101010111111010101010101010010100101011001010101010101010100110111010101111010";
            //Makes previous buttons not visible
            consoleBtn.Visible = false;
            //END

        }

        private void button6_Click(object sender, EventArgs e)
        {
            libPanel.Visible = true;
            libPanel.Dock = DockStyle.Fill;
            libPanel.BringToFront();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            libPanel.Controls.Add(formatPanel);
            formatPanel.Dock = DockStyle.Fill;
            formatPanel.BringToFront();
            formatPanel.Visible = true;
            formatPanel.Controls.Add(formatText);
            formatText.Font.Equals(formatBox.Font);
            formatText.Text = formatBox.Text;
            formatText.Dock = DockStyle.Fill;
            formatText.ReadOnly = true;
            //
            clubBtn.Visible = false;
            kernelFolder.Visible = false;
            guiFolder.Visible = false;
            updateFolder.Visible = false;
            updateFolder.Visible = false;
            xiFolder.Visible = false;
        }

        private void clubBtn_Click(object sender, EventArgs e)
        {
            libPanel.Controls.Add(clubsubPanel);
            clubsubPanel.Dock = DockStyle.Fill;
            clubsubPanel.BringToFront();
            clubsubPanel.Visible = true;
            
        }

        private void subpanelBtn_Click(object sender, EventArgs e)
        {
            clubsubPanel.Controls.Add(clubPanel);
            clubPanel.Dock = DockStyle.Fill;
            clubPanel.BringToFront();
            clubPanel.Visible = true;
            clubPanel.Controls.Add(clubText);
            clubText.Dock = DockStyle.Fill;
            clubText.Visible = true;
            clubText.ReadOnly = true;
            clubText.Text = "///<summary>\r\"EMPTY FILE\r\"///</summary>";
            subpanelBtn.Visible = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            (new error_msg()).ShowDialog();
        }

        private void guiFolder_Click(object sender, EventArgs e)
        {
            this.libPanel.Controls.Add(guiPanel);
            guiPanel.Dock = DockStyle.Fill;
            guiPanel.Visible = true;
            guiPanel.BringToFront();
        }

        private void updateFolder_Click(object sender, EventArgs e)
        {
            this.libPanel.Controls.Add(updatePanel);
            this.updatePanel.Visible = true;
            this.updatePanel.Dock = DockStyle.Fill;
            this.updatePanel.BringToFront();
        }

        private void kernelFolder_Click(object sender, EventArgs e)
        {
            this.libPanel.Controls.Add(kernelPanel);
            this.kernelPanel.Visible = true;
            this.kernelPanel.Dock = DockStyle.Fill;
            this.kernelPanel.BringToFront();

        }

        private void xiFolder_Click(object sender, EventArgs e)
        {
            libPanel.Controls.Add(xiPanel);
            xiPanel.Dock = DockStyle.Fill;
            xiPanel.Visible = true;
            xiPanel.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            root1.Visible = true;
            root1.BringToFront();
            root1.Select();
        }

        private void root1_VisibleChanged(object sender, EventArgs e)
        {
            if (root1.Visible == true)
            {
                // !null
            }
            else
            {
                privatePanel.Visible = true;
                privatePanel.Dock = DockStyle.Fill;
                privatePanel.BringToFront();
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new int_test()).ShowDialog();
        }

        private void button13_Click_2(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(privatePanel);
            binPanel.Dock = DockStyle.Fill;
            binPanel.BringToFront();
            binPanel.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(tmpPanel);
            tmpPanel.Visible = true;
            tmpPanel.BringToFront();
            tmpPanel.Dock = DockStyle.Fill;
            tmpPanel.Select();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Add(root2);
            root2.Visible = true;
            root2.VisibleChanged += new EventHandler(root2_VisibleChanged);
            root2.BringToFront();
        }

        void root2_VisibleChanged(object sender, EventArgs e)
        {
            if (root2.Visible == true)
            {

            }

            else
            {
                panel1.Controls.Add(kryptonPanel);
                kryptonPanel.Visible = true;
                kryptonPanel.Dock = DockStyle.Fill;
                kryptonPanel.BringToFront();
                root2.Visible = false;
            }
        }
    }
}
