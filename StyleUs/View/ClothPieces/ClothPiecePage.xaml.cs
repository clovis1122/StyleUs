﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using StyleUs.View.ClothPieces;

namespace StyleUs.View
{
    public partial class ClothPiecePage : TabbedPage
    {
        public ClothPiecePage()
        {
            try
            {
                InitializeComponent();
            } catch(Exception e) {
                e.GetType();
            }

        }
    }
}