using AngleSharp.Html.Parser;
using Find_Auto.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Auto
{
    public partial class ViewerForm : Form
    {

        Parsing parsing;
        HtmlLoader loader;

        string[] imgList;
        int maxImg, currentImg;

        public ViewerForm(string url, string model, string description, string year, string price)
        {
            InitializeComponent();
            loader = new HtmlLoader();
            parsing = new Parsing();

            Name.Text = "Model: " + model;
            Description.Text = "Description: " + description;
            Year.Text = "Year: " + year;
            Price.Text = "Price: " + price;
            LoadingData(url);
        }

        private void buttonNextImg_Click(object sender, EventArgs e)
        {
            if(currentImg+1 <= maxImg)
            {
                currentImg++;
                pictureBox.ImageLocation = imgList[currentImg];
                labelCurrentImg.Text = (currentImg + 1).ToString();
            }
            else
            {
                currentImg = 0;
                pictureBox.ImageLocation = imgList[currentImg];
                labelCurrentImg.Text = (currentImg + 1).ToString();
            }
        }

        private void buttonPrevImg_Click(object sender, EventArgs e)
        {
            if (currentImg - 1 >= 0)
            {
                currentImg--;
                pictureBox.ImageLocation = imgList[currentImg];
                labelCurrentImg.Text = (currentImg + 1).ToString();
            }
            else
            {
                currentImg = maxImg;
                pictureBox.ImageLocation = imgList[currentImg];
                labelCurrentImg.Text = (currentImg + 1).ToString();
            }

        }


        public async void LoadingData(string sourceUrl)
        {
            var domParser = new HtmlParser();
            var source = await loader.GetSource(sourceUrl);
            var document = await domParser.ParseDocumentAsync(source);
            imgList = parsing.ViewerImages(document);
            maxImg = imgList.Length-1;
            labelMaxImg.Text = (maxImg + 1).ToString();
            currentImg = 0;
            labelCurrentImg.Text = (currentImg + 1).ToString();
            pictureBox.ImageLocation = imgList[currentImg];
        }



    }
}
