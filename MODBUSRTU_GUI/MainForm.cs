using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODBUSRTU_CLASS;
using MODBUSRTU_GUI.ChildForms;
using MODBUSRTU_GUI.SettingForms;

namespace MODBUSRTU_GUI
{
    public partial class MainForm : Form
    {
        private ModbusRTU ModbusMaster = new ModbusRTU();
        private AA_SystemInfoForm WorkSpcaeSystemInfoForm = new AA_SystemInfoForm();
        private AB_FaultInfoForm WorkSpcaeFaultInfoForm = new AB_FaultInfoForm();
        private AC_RTWaveformForm WorkSpcaeWaveformForm = new AC_RTWaveformForm();
        private AD_WorkModeForm WorkSpaceWorkModeForm = new AD_WorkModeForm();
        public MainForm()
        {
            InitializeComponent();
            WorkSpcaeSystemInfoForm.MdiParent = this;
            WorkSpcaeFaultInfoForm.MdiParent = this;
            WorkSpcaeWaveformForm.MdiParent = this;
            WorkSpaceWorkModeForm.MdiParent = this;

            treeView1.ExpandAll();

            ModbusRTU.IsMaster = true;
            ModbusRTU.AssembleRequestADU(1, ModbusRTU.LoadUnmannedBuses((byte)ModbusRTU.ModbusFuncCode.ReadStorageRegs, 8));
            ModbusRTU.AssembleRequestADU(1, ModbusRTU.LoadUnmannedBuses((byte)ModbusRTU.ModbusFuncCode.ReadInputRegs, 8));
            ModbusRTU.AssembleRequestADU(1, ModbusRTU.LoadUnmannedBuses((byte)ModbusRTU.ModbusFuncCode.ReadCoils, 8));

        }
        private void 通讯设置ToolStripMenuItem_Click(object sender, EventArgs e)//新建并打开通讯设置窗口
        {
            CommSettingForm ComSettingForm = new CommSettingForm();
            ComSettingForm.ShowDialog();
        }




        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "SystemStatus")
            {
                WorkSpcaeSystemInfoForm.Show();
                WorkSpcaeSystemInfoForm.Activate();
            }
            if (treeView1.SelectedNode.Name == "Waveforms")
            {
                WorkSpcaeWaveformForm.Show();
                WorkSpcaeWaveformForm.Activate();
            }
            if (treeView1.SelectedNode.Name == "FaultMsg")
            {
                WorkSpcaeFaultInfoForm.Show();
                WorkSpcaeFaultInfoForm.Activate();
            }
            if (treeView1.SelectedNode.Name == "WorkMode")
            {
                WorkSpaceWorkModeForm.Show();
                WorkSpaceWorkModeForm.Activate();
            }
        }
    }
}
