﻿using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.View
{
    public partial class ItemEspecialView : Form
    {
        public ItemEspecialView(ItemEspecial item)
        {
            InitializeComponent();
            picItem.Image = Image.FromFile(item.UrlImg);
            if (item.Nome.Contains("Picareta"))
                picBuff.Image = Image.FromFile("../../icon/Pick-icon.png");
            else
                picBuff.Image = Image.FromFile("../../icon/Mochila-icon.png");
        }
    }
}
