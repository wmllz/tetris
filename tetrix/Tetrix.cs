using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace tetrix
{
    public partial class Tetrix : Form
    {
        public singleGame pa2;
        private bool gameFlag = true;
        public Tetrix(singleGame pa, bool flag = true)
        {
            //如果flag 为true则为新建游戏
            //否则为继续游戏
            InitializeComponent();
            pa2 = pa;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            gameFlag = flag;
        }
        public Tetrix(singleGame pa, int score, int level, String curtetrix, String nexttetrix, String bg, bool flag = true)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            pa2 = pa;
            this.score = score;
            this.level = level;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    curTetrix[i, j] = Convert.ToInt32(curtetrix[i * 2 + j]) - 48;
                    nextTetrix[i, j] = Convert.ToInt32(nexttetrix[i * 2 + j]) - 48;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    background[i, j] = Convert.ToInt32(bg[i * 14 + j]) - 48;
                }
            }
            gameFlag = flag;
        }

        //定义变量
        public int[,] curTetrix = new int[4, 2];             //用来存储当前下落的方块的坐标   
        public int[,] nextTetrix = new int[4, 2];            //用来存储下一个下落的方块的坐标 
        public enum TetrixPiece { NoShape, ZShape, SShape, 
            LShape, TShape, OShape, JShape, IShape };         //定义形状，一共有8种
        public TetrixPiece curTetrixShape;             //用来存储当前下落方块的形状
        public TetrixPiece nextTetrixShape;            //用来存储下一个方块的形状
        private Random rad = new Random();              //用来产生随机数
        private Image mainImage;                        //在它上面画游戏界面
        private Image nextImage;                        //在它上面画下一个方块
        private int location = 7;                   //用来设定当前方块出现的位置（希望从中间下落）
        private int allLine = 0;                    //用来记录到目前为止已经消了多少行,初始化为0
        private int oldLine = 0;
        public int score = 0;                      //用来记录分数
        public int level = 1;                      //用来记录级别默认为0
        
        
        //用坐标的方式定义方块，其中每个坐标代表每个方块中的小方块的左上坐标
        //并且tetrixCoords[0]~tetrixCoords[7]依次是N、Z、S、L、T、O、J、I方块
        //对应的颜色分别为：YellowGreen、Red、Green、Yello、Purple、Blue、gray、Pink
        private int[, ,] tetrixCoords = new int[8, 4, 2]{{{0, 0}, {0, 0}, {0, 0}, {0, 0}},
                                                         {{0, 1}, {0, 2}, {1, 0}, {1, 1}},
                                                         {{0, 0}, {0, 1}, {1, 1}, {1, 2}},
                                                         {{0, 0}, {0, 1}, {0, 2}, {1, 2}},
                                                         {{0, 1}, {1, 1}, {1, 0}, {2, 1}},
                                                         {{0, 0}, {1, 0}, {0, 1}, {1, 1}},
                                                         {{0, 2}, {1, 2}, {1, 1}, {1, 0}},
                                                         {{0, 0}, {0, 1}, {0, 2}, {0, 3}}};

        //定义背景
        public int[,] background ={  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},  
                                    {1,1,1,1,0,1,0,1,0,0,0,0,0,1}};  

        private void Tetrix_Load(object sender, EventArgs e)
        {
            //初始化图像
            mainImage = new Bitmap(mainWindow.Width, mainWindow.Height);
            nextImage = new Bitmap(nextWindow.Width, nextWindow.Height);
            this.KeyPreview = true;
               
        }
        protected override void OnPaint(PaintEventArgs e)
        {   
            Pen pn = new Pen(Color.Blue);
            //drawImage();         
            base.OnPaint(e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            /*功能：处理键盘消息
            *UP：旋转方块
            *Right：向右移动方块
            *Left：向左移动方块
            *Down：加速下降*/
            switch (keyData)
            {
                case Keys.Up:
                    changeTetrix(curTetrix);
                    drawImage();
                    break;
                case Keys.Left:
                    if (checkLeft(curTetrix))
                    {
                        //检查通过,将方块中的4个小方块的各横坐标减1
                        for (int i = 0; i < 4; i++)
                        {
                            curTetrix[i, 0] -= 1;
                        }
                    }
                    drawImage();
                    break;
                case Keys.Right:
                    if (checkRight(curTetrix))
                    {
                        //检查通过,将方块中的4个小方块的各横坐标减1
                        for (int i = 0; i < 4; i++)
                        {
                            curTetrix[i, 0] += 1;
                        }
                    }
                    drawImage();
                    break;
                case Keys.Down:
                    for (int i = 20; i >= 0; i--)
                    {
                        if (!downTetrix(curTetrix)) {
                            break;
                        }
                    }
                    break;
            }
            if (keyData == Keys.Up || keyData == Keys.Down ||
              keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }
        private void changeTetrix(int[,] curTetrix) { 
            /*功能：用于改变当前方块的形状，当按上方向键时
             *当前方块顺时针旋转90度
             *算法：根据数学公式，将一点A（x,y）绕原点旋转90度得
             *新的点（y,-x）,当绕的点O(p,q)不是原点时可以先将原点移到O点
             *处，此时A的坐标为(（x-p）,(y-q))，旋转后变成（（y-q）,(p-x)）
             *则原位置应该为(（y-q+p）,(p-x+q))
             *分析的将O点设为方块中四个小方块中左上角最大x最大y坐标对应的坐标（(xMax+xMin)/2，(yMax+yMin)/2）*/

            int xMax = maxX(curTetrix);
            int yMax = -maxY(curTetrix);
            int xMin = minX(curTetrix);
            int yMin = -minY(curTetrix);
            int xTemp = (xMax + xMin) / 2 +1;
            int yTemp = (yMax + yMin) / 2;
            int[,] newTetrix = new int[4,2];

            if (xTemp != 1 && yTemp != 0) {
                for (int i = 0; i < 4; i++)
                {
                    newTetrix[i, 0] = -curTetrix[i, 1] - yTemp + xTemp;
                    newTetrix[i, 1] = -(xTemp - curTetrix[i, 0] + yTemp) + 1;
                    if (newTetrix[i, 0] < 0 || newTetrix[i, 1] < 0)
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
            
            if (checkRight(newTetrix) && checkLeft(newTetrix) &&
                checkDown(newTetrix) && checkUp(newTetrix))
            {
                for (int i = 0; i < 4; i++) {
                    curTetrix[i, 0] = newTetrix[i, 0] - 1;
                    curTetrix[i, 1] = newTetrix[i, 1];
                }
            }
        }
        private void drawCurrentTetrix(Graphics g) { 
            /*用于绘制当前下落的方块*/
            //定义变量
            Rectangle rect;
            SolidBrush brush;
            brush = getBrush(curTetrixShape);
            //绘制方块
            for (int i = 0; i < 4; i++)
            {
                rect = new Rectangle(curTetrix[ i, 0]*30 , curTetrix[i, 1]*30 , 30, 30);
                g.DrawRectangle(new Pen(Color.White, 4), rect);
                g.FillRectangle(brush, rect);
            }  
        }
        private void drawBackground(Graphics g) {
            /*用于绘制面板的背景*/
            
            //定义变量
            Rectangle rect;
            TetrixPiece TempShape;
            SolidBrush brush;

           
            //绘制背景
            for (int bgy = 0; bgy < 20; bgy++)
            {
                for (int bgx = 0; bgx < 14; bgx++)
                { 
                    if (background[bgy, bgx] != 0)
                    {
                        TempShape = (TetrixPiece)background[bgy, bgx];
                        brush = getBrush(TempShape);  
                        rect = new Rectangle(bgx * 30, bgy * 30, 30, 30);
                        g.DrawRectangle(new Pen(Color.White, 4), rect);
                        g.FillRectangle(brush, rect);
                    }
                }
            }  
        }
        private void drawNextTetrix(Graphics g)
        {
            /*用于绘制当前下落的方块*/
            //定义变量
            Rectangle rect;
            SolidBrush brush;
            brush = getBrush(nextTetrixShape);
            //绘制方块
            for (int i = 0; i < 4; i++)
            {
                rect = new Rectangle(nextTetrix[i, 0] * 30, nextTetrix[i, 1] * 30, 30, 30);
                g.DrawRectangle(new Pen(Color.White, 4), rect);
                g.FillRectangle(brush, rect);
            }
        }
        private void drawImage()
        {
            /*功能：画图，包括当前方块，和背景画图*/
            Graphics g = Graphics.FromImage(mainImage);
            Graphics gr = Graphics.FromImage(nextImage);
            g.Clear(this.BackColor);
            gr.Clear(this.BackColor);
            drawCurrentTetrix(g);           //绘制当前下落的方块
            drawBackground(g);              //绘制背景
            drawNextTetrix(gr);             //绘制下一个方块
            Graphics gra = mainWindow.CreateGraphics();
            Graphics grap = nextWindow.CreateGraphics();
            grap.DrawImage(nextImage, 0, 0);
            gra.DrawImage(mainImage, 0, 0);
        }
        private void timer1_Tick(object sender, EventArgs e){
            /*时钟事件，当时钟到达相应的时间点时，调用此函数*/
            downTetrix(curTetrix);
        }
        private bool downTetrix(int[,] curTetrix) {
            /*功能：当没有操作时，当前方块持续下落（保持一定的速度）
             * 主要操作是判断是否越界，是否可下落，是否到达了最大高度，
             * 如果到达最大高度，则游戏结束。否则当不可下落时，
             *将当前方块转换成背景数组存储*/
            
            if (checkDown(curTetrix)){
                //检查通过，将各y坐标加1
                for (int i = 0; i < 4; i++) {
                    curTetrix[i, 1] += 1;
                }
                drawImage();            //绘图
                return true;
            }else{  
                int yMin = minY(curTetrix);
                if (yMin == 0)
                {
                    //游戏结束
                    timer1.Stop();
                    getName win = new getName(this);
                    win.scoreDisp.Text = score.ToString();
                    win.rankDisp.Text = level.ToString();
                    win.ShowDialog();
                    this.Close();
                }
                else {
                    changeCrdsToBg(curTetrix);      //下落完成，修改背景
                    removeLine();
                    getRandomTetrix();              //得到下一个方块
                    drawImage();                    //绘图
                }
                return false;
            }  
        }
        private void changeCrdsToBg(int[,] curTetrix) { 
            /*功能：将当前方块的坐标转换成背景对应的数组*/
            int xTemp = 0;
            int yTemp = 0;
   
            for (int i=0; i< 4; i++){
                xTemp = curTetrix[i, 0];
                yTemp = curTetrix[i, 1];
                background[yTemp, xTemp] = (int)curTetrixShape;
            }
        }      
        private int maxY(int[,] Tetrix) { 
            /*功能：用于得到方块中的4个小方
             * 块的最大y坐标
             *返回：最大y坐标*/
            int yTemp = Tetrix[0, 1];
            for (int i = 0; i < 4; i++) {
                yTemp = (yTemp > Tetrix[i, 1]) ? yTemp : Tetrix[i, 1];
            }
            return yTemp;
        }
        private int minY(int[,] Tetrix) {
            /*功能：用于得到方块中的4个小方
            * 块的最小y坐标
            *返回：最小y坐标*/
            int yTemp = Tetrix[0, 1];
            for (int i = 0; i < 4; i++)
            {
                yTemp = (yTemp < Tetrix[i, 1]) ? yTemp : Tetrix[i, 1];
            }
            return yTemp;
        }
        private int minX(int[,] Tetrix) {
            /*功能：用于得到方块中的4个小方
           * 块的最小x坐标
           *返回：最小x坐标*/
            int xTemp = Tetrix[0, 0];
            for (int i = 0; i < 4; i++)
            {
                xTemp = (xTemp < Tetrix[i, 0]) ? xTemp : Tetrix[i, 0];
            }
            return (xTemp);
        }
        private int maxX(int[,] Tetrix) {
            /*功能：用于得到方块中的4个小方
             * 块的最大x坐标
             *返回：最大x坐标*/
            int xTemp = Tetrix[0, 0];
            for (int i = 0; i < 4; i++)
            {
                xTemp = (xTemp > Tetrix[i, 0]) ? xTemp : Tetrix[i, 0];
            }
            return (xTemp);
        }  
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (gameFlag)
            {
                newGame();
            }
            else {
                continueGame();
            }
            
        }
        private void newGame() {
            /*功能：创建新游戏*/
            if (startBtn.Text == "开始游戏")
            {
                startBtn.Text = "暂停游戏";
                nextTetrixShape = (TetrixPiece)rad.Next(1, 8);
                this.axWindowsMediaPlayer1.URL = @"d:\music.mp3";
                this.axWindowsMediaPlayer1.Ctlcontrols.play();       //播放背景音乐

                getRandomTetrix();
                this.Focus();
            }
            else if (startBtn.Text == "暂停游戏")
            {
                startBtn.Text = "开始游戏";
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();     //暂停背景音乐
                timer1.Stop();
            }
        }
        private void continueGame(){
            /*功能：继续游戏*/
            if (startBtn.Text == "开始游戏")
            {
                startBtn.Text = "暂停游戏";
                this.axWindowsMediaPlayer1.URL = @"d:\music.mp3";
                this.axWindowsMediaPlayer1.Ctlcontrols.play();       //播放背景音乐
                timer1.Start();
                this.Focus();
            }
            else if (startBtn.Text == "暂停游戏")
            {
                startBtn.Text = "开始游戏";
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();     //暂停背景音乐
                timer1.Stop();
            }
        }
        private void getRandomTetrix() { 
            /*功能：得到随机方块*/
            curTetrixShape = nextTetrixShape;
            nextTetrixShape = (TetrixPiece)rad.Next(1, 8);
            for (int x = 0; x < 4; x++) { 
                nextTetrix[x, 0] = tetrixCoords[(int)nextTetrixShape, x, 0];
                nextTetrix[x, 1] = tetrixCoords[(int)nextTetrixShape, x, 1];
                curTetrix[x, 0] = tetrixCoords[(int)curTetrixShape, x, 0] + location;
                curTetrix[x, 1] = tetrixCoords[(int)curTetrixShape, x, 1];      
            }
            
            timer1.Start();
        }
        private bool checkRight(int[,] curTetrix)
        {
            /*功能：检查当前方块是否能够向右移动
            *如果不能则让方块在水平方向上保持原位*/
            int xTemp = 0;
            int yTemp = 0;
            int xMax = maxX(curTetrix);

            if (xMax >= 13)
            {
                //超过了边界
                return false;
            }
            for (int i = 0; i < 4; i++)
            {
                xTemp = curTetrix[i, 0];
                yTemp = curTetrix[i, 1];

                if (background[yTemp, xTemp] != 0 || background[yTemp, xTemp] != 0)
                {
                    //碰到已固定的方块
                    return false;
                }
            }
            return true;
        }
        private bool checkLeft(int[,] curTetrix)
        {
            /*功能：检查当前方块是否能够向左移动
             *如果不能则让方块在水平方向上保持原位*/
            int xTemp = 0;
            int yTemp = 0;
            int xMin = minX(curTetrix);

            if (xMin <= 0)
            {
                //超过了边界
                return false;
            }
            for (int i = 0; i < 4; i++)
            {
                xTemp = curTetrix[i, 0];
                yTemp = curTetrix[i, 1];

                if (background[yTemp, xTemp] != 0 || background[yTemp, xTemp - 1] != 0)
                {
                    //碰到已固定的方块
                    return false;
                }
            }
            return true;          
        }
        private bool checkDown(int[,] curTetrix)
        {
            /*功能：检查当前方块是否能够继续下降，
             * 或者说检查下一次下落方块是否碰撞到
             * 已固定的方块或者超越边界
             */

            int xTemp = 0;
            int yTemp = 0;
            int yMax = maxY(curTetrix);

            if (yMax >= 19)
            {
                //超过了边界
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                xTemp = curTetrix[i, 0] ;
                yTemp = curTetrix[i, 1] + 1;

                if (background[yTemp, xTemp] != 0)
                {
                    //碰到已固定的方块
                    return false;
                }
            }
            return true;
        }
        private bool checkUp(int[,] curtetrix) {
            /*功能：检查当前方块是否能够继续变形 */

            int xTemp = 0;
            int yTemp = 0;
            int yMin = minY(curTetrix);

            if (yMin < 0)
            {
                //超过了边界
                return false;
            }
            return true;
        }
        private void removeLine() {
            /*功能：用于消行当一行被方块填满后，就消去该行并且将上一行移到下一行中*/
            int count = 0;  //用来计算一行中的小方块数
            int num = 0;         //用来计算消得行数（从零开始）
            int [] lineNum = new int[4];        //用来存储要消的行号
            int topLine = 0;            //用来存储背景的顶行
            oldLine = allLine;
            //用来找出要消的行号
            for (int row = 19; row >= 0; row--) {
                for(int column = 0; column <= 13; column++){
                    if (background[row, column] != 0) {
                        count += 1;
                    }
                }
                if (count == 14) {
                    allLine++;
                    lineNum[num++] = row;
                    for (int j = 0; j <= 13; j++)
                    {
                        background[row, j] = 0;
                    }
                    
                }else if(count == 0){
                    topLine = row + 1;
                    break;
                }
                count = 0;
            }
            //消行
            if (num != 0) {
                for (int i = num-1; i >= 0; i--)
                {
                    for (int temp = lineNum[i]; temp >= topLine; temp--)
                    {
                        for (int j = 0; j <= 13; j++)
                        {
                            background[temp, j] = background[temp - 1, j];
                        }
                    }
                }
            }
            changeScore(num);
        }
        private void changeScore(int numRemove) { 
            /*功能：修改得分，规定一次消一行得5分，
             * 消两行得15分，消三行得25分，消四行得35分*/
            if (numRemove > 0) {
                score = allLine * 5 + numRemove * 5 - 5;
            }

            if (score <= 9999)
            {
                num1.Number = score % 10;
                num2.Number = (score % 100) / 10;
                num3.Number = (score % 1000) / 100;
                num4.Number = score / 10000;
            }
            else
            {
                score = 0;
            }
            changeLevel();
        }
        private SolidBrush getBrush(TetrixPiece tetrixShape) {
            /*功能：根据tetrix的形状获得画刷的颜色*/
            SolidBrush brush = new SolidBrush(Color.YellowGreen);
            switch (tetrixShape)
            {
                case TetrixPiece.NoShape:
                    brush = new SolidBrush(Color.YellowGreen);
                    break;
                case TetrixPiece.ZShape:
                    brush = new SolidBrush(Color.Red);
                    break;
                case TetrixPiece.SShape:
                    brush = new SolidBrush(Color.Green);
                    break;
                case TetrixPiece.LShape:
                    brush = new SolidBrush(Color.Yellow);
                    break;
                case TetrixPiece.TShape:
                    brush = new SolidBrush(Color.Purple);
                    break;
                case TetrixPiece.OShape:
                    brush = new SolidBrush(Color.Blue);
                    break;
                case TetrixPiece.JShape:
                    brush = new SolidBrush(Color.Gray);
                    break;
                case TetrixPiece.IShape:
                    brush = new SolidBrush(Color.Pink);
                    break;
            }
            return brush;
        }
        private void changeLevel() { 
            /*功能：当分数达到一定分数时，
             * 增加游戏的难度，
             * 同时修改游戏的级别数*/
            int argument = 100;
            
            if (score > argument * level)
            {
                level++;
                timer1.Stop();
                timer1.Interval -= 10;
                timer1.Start();

                num5.Number = level % 10;
                num6.Number = (level % 100) / 10;
                num7.Number = (level % 1000) / 100;
                num8.Number = level / 10000;      
            }
    
        }
        private void connDatabase() { 
            /*功能：连接数据库*/
            string connString = @"Data Source=127.0.0.1;Database=Tetrix; Trusted_Connection=Yes;Connect Timeout=90";
            using (SqlConnection conn = new SqlConnection(connString));

        }
        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            if((int)axWindowsMediaPlayer1.playState == 1){
                this.axWindowsMediaPlayer1.Ctlcontrols.play();       //播放背景音乐
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*功能：用于创建保存游戏窗口*/
            String curCoords = "";
            String nextCoords = "";
            String bgState = "";
            
            timer1.Stop();
            for     (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    curCoords += this.curTetrix[i, j];
                    nextCoords += this.nextTetrix[i, j];
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    bgState += this.background[i, j];
                }
            }
            saveGame saveForm = new saveGame(this, curCoords, nextCoords, bgState);
            saveForm.scoreDisp.Text = score.ToString();
            saveForm.rankDisp.Text = level.ToString();
            saveForm.ShowDialog();
            
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pa2.pa1.Close();
            
        }

    }
    
}  


