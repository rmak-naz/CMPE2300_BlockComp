using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Threading;

namespace ICA5_BlockComp
{
    public partial class ICA5_BlockComp : Form
    {
        private List<ICA5_Block> _blockList;
        private static Random _rnd = new Random();
        private static CDrawer _canvas = new CDrawer();
        private const int _rows = 800/ICA5_Block._blockSize;
        private const int _cols = 600/ICA5_Block._blockSize;
        private delegate void delVoidString(string str);

        public ICA5_BlockComp()
        {
            InitializeComponent();
            _canvas.ContinuousUpdate = false;
        }

        private void B_Randomize_Click(object sender, EventArgs e)
        {
            _blockList = new List<ICA5_Block>();
            
            for (int col = 0; col < _cols; ++col)
            {
                for (int row = 0; row < _rows; ++row)
                {
                    Color rndColor = Color.FromArgb(_rnd.Next(32,256), _rnd.Next(32, 256), _rnd.Next(32, 256));
                    _blockList.Add(new ICA5_Block(rndColor));
                }
            }
            Render();
            B_Sort.Enabled = true;
        }

        private void B_Sort_Click(object sender, EventArgs e)
        {
            if (RB_Brightness.Checked)
            {
                ICA5_Block._sort = ICA5_Block.SortStyle.Brightness;
            }
            else if (RB_Hue.Checked)
            {
                ICA5_Block._sort = ICA5_Block.SortStyle.Hue;
            }
            else
            {
                ICA5_Block._sort = ICA5_Block.SortStyle.Saturation;
            }
            Thread sortThread = null;

            sortThread = new Thread(SortList);
            sortThread.IsBackground = true;
            sortThread.Start();

        }

        private void SortList()
        {   
            lock (_blockList)
            {                
                _blockList.Sort();
                Render();
                Invoke(new delVoidString(Status),ICA5_Block._compareCount.ToString());
            }
        }

        private void Render()
        {
            int blockCount = 0;

            _canvas.Clear();

            while (blockCount < _blockList.Count())
            for (int col = 0; col < _cols; ++col)
            {
                for (int row = 0; row < _rows; ++row)
                {
                        int x = row * ICA5_Block._blockSize;
                        int y = col * ICA5_Block._blockSize;
                        _blockList[blockCount].Render(x, y, _canvas);
                        ++blockCount;
                }
            }
            _canvas.Render();
        }

        private void Status(string info)
        {
            LB_CompNum.Text = info;
        }
        
    }
}
