﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.DinerPancakeMenu
{
    internal abstract class MenuComponent
    {

        public virtual void Add(MenuComponent menuComponent) => throw new NotImplementedException();
        public virtual void Remove(MenuComponent menuComponent) => throw new NotImplementedException();
        public virtual MenuComponent GetChild(int i) => throw new NotImplementedException();
    
        public virtual string GetName() => throw new NotImplementedException();
        public virtual string GetDescription() => throw new NotImplementedException();
        public virtual double GetPrice() => throw new NotImplementedException();
        public virtual bool IsVegetarian() => throw new NotImplementedException();

        public virtual void Print() => throw new NotImplementedException();

        public abstract IEnumerator<MenuComponent> CreateEnumerator();
    }
}
