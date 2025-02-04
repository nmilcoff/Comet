﻿using System;

namespace Comet 
{
	public class Slider : View
	{
		public Slider (
			Binding<float> value = null, 	
			float from = 0, 
			float through = 100, 
			float by = 1,
			Action<float> onEditingChanged = null)
		{
            Value = value;
			From = from;
			Through = through;
			By = by;
			OnEditingChanged = new MulticastAction<float>(value, onEditingChanged);
		}
		
		


        Binding<float> _value;
        public Binding<float> Value
        {
            get => _value;
            private set => this.SetBindingValue(ref _value, value);
        }

        Binding<float> _from;
		public Binding<float> From {
			get => _from;
            private set => this.SetBindingValue(ref _from, value);
        }

        Binding<float> _through;
		public Binding<float> Through {
			get => _through;
            private set => this.SetBindingValue(ref _through, value);
        }

        Binding<float> _by;
		public Binding<float> By {
			get => _by;
            private set => this.SetBindingValue(ref _by, value);
        }
		
		public Action<float> OnEditingChanged { get; private set; }
	}
}
