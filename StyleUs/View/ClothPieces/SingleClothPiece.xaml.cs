﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StyleUs.View.ClothPieces
{
    public partial class SingleClothPiece : ContentPage
    {
        public SingleClothPiece()
        {
			try
			{
				InitializeComponent();
			}
			catch (Exception e)
			{
				var du = e.Message;

			}
        }
    }
}
