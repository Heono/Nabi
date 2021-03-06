﻿using System.Windows.Controls;
using System.Windows;
using Xceed.Wpf.AvalonDock.Layout;
using Nabi.Templates.ViewModels.Tools;
using Nabi.Templates.ViewModels.AD;

namespace Nabi.Templates
{
	/// <summary>
	/// Implements a <see ref="DataTemplateSelector"/> for AvalonDock's documents and toolwindows.
	///
	/// One instance of this class is usually initialized in XAML and it returns
	/// a view for a specific given type of viewmodel.
	/// </summary>
	internal class PanesTemplateSelector : DataTemplateSelector
	{
		/// <summary>
		/// Default class constructor.
		/// </summary>
		public PanesTemplateSelector()
		{
		}

		/// <summary>
		/// Gets/sets the view instance of the file document.
		/// </summary>
		public DataTemplate FileViewTemplate { get; set; }

		/// <summary>
		/// Gets/sets the view instance of the file stats tool window.
		/// </summary>
		public DataTemplate FileStatsViewTemplate { get; set; }

		/// <summary>
		/// Gets/sets the view instance of the file stats tool window.
		/// </summary>
		public DataTemplate ColorPickerViewTemplate { get; set; }

		/// <summary>
		/// Gets a template for simple testing tool windows.
		/// </summary>
		public DataTemplate Output_ViewTemplate { get; set; }

		public DataTemplate Log_ViewTemplate { get; set; }

		/// <summary>
		/// Determines the matching view for a specific given type of viewmodel.
		/// </summary>
		/// <param name="item">Identifies the viewmodel object for which we require an associated view.</param>
		/// <param name="container">Identifies the container's instance that wants to resolve this association.</param>
		public override System.Windows.DataTemplate SelectTemplate(object item,
																   System.Windows.DependencyObject container)
		{
			var itemAsLayoutContent = item as LayoutContent;

			if (item is FileViewModel)
				return FileViewTemplate;

			if (item is FileStatsViewModel)
				return FileStatsViewTemplate;

			if (item is ColorPickerViewModel)
				return ColorPickerViewTemplate;

			if (item is Output_ViewModel)
				return Output_ViewTemplate;

			if (item is Log_ViewModel)
				return Log_ViewTemplate;

			return base.SelectTemplate(item, container);
		}
	}
}
