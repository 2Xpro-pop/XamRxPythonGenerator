using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Xamarin.Forms;

namespace TestSharp.Hi.ViewModels
{
    public class Admin2ViewModel: ReactiveObject
    {
        [Reactive] public string RxText { get; set; }

        public Admin2ViewModel()
        {
            RxText = "Fody & RxUI ♡!"
        }
    }
}
