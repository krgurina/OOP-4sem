   M S B A M L   `   `   `  ����?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:shop.Views.Adminshop.Views.Admin  5      =#clr-namespace:shop.ViewModels.Adminshop.ViewModels.Admin  5          shop.Views.AddProductView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=22.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:shop.Views.Admin     5      9	viewModel#clr-namespace:shop.ViewModels.Admin     5      -   5          N� Title$  CategoriesView��5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��77* �6   �� 5      $
��123* �6   .+�5   
   � $��0��6   .+�5      �� $��15, 15,0 ,0q�6    �� Orientation$ Vertical=�6.   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��15(�6    $��Название��6.   �� 5      -   5         ��Name$ ProductName��5      $	��217��6J    J� RenderTransformOrigin$ 0.5,0.5&�6V   ��63   �� *Title+6V   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��15(�6    $��Категория��6.   �� 5      -   5         ��Name$ ProductCategoryName��5      $	��100��6�   $��1q�6�   
�������$	��220��6�   ��6<   �� *
Categories+ �� SelectedItem 6`   �� *SelectedCategory+��5      �� 5      .R�5   "   �� $��0q�6B   $��Bottom=�6M   $��Center=�5   (   ��5   ,   �� *Name+5   (   5       5"      5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��15(�6    $��цена��6.   �� 5'      -   5        $ Price��5'      $	��217��6D   $ 0.5,0.5&�6P   ��6-   �� *Price+6P   5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��15(�6    $��
ID categor��6.   �� 5+      $	��217��6;   $ 0.5,0.5&�6G   ��6   �� *
CategoryId+6G   5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��15(�6    $��Описание��6.   �� 5/      -   5        $ ProductDescription��5/      $	��217��6W   $ 0.5,0.5&�6c   ��6:   �� *Description+6c   50      �� 51      $ 
Horizontal=�6   .+�52      �� $��15(�6    $��
image link��6.   �� 53      -   5        $ ProductImage��53      $	��217��6O   $ 0.5,0.5&�6[   ��64   �� *	ImageLink+6[   54      �� 55      -   5        $��добавить��55      $
��0 10q�6g   ��6,   �� *AddProductCommand+6g   �� 57      $��удалить��6   $
��0 10q�6T   ��6+   �� *DeleteProducеCommand+6T   �� 59      $ 
Horizontal=�6   .+�5:      �� -   5        $ SearchRequest��5:      $	��200��6]   $��10q�6i   �� 5;      $��
поиск��6   5=      5>      5A      � 5D   
   $��1��6   .+�5E      &   System.Windows.Controls.DataGrid  -	   5          Name$ ProductsGrid��5E         AutoGenerateColumns .  	   
IsReadOnly	 .  6-   �� *SelectedItemForDataGrid+
 �� UpdateSourceTrigger$
 PropertyChanged=���6�   �� *
Products+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *ID+  5H      $ TITLE��6)   $ * 68    6B   �� *Title+  5I      $ CATEGORY��6)   $ * 6;    6E   �� *
Category+  5J      $ PRICE��6)   $ * 68    6B   �� *Price+  5K      $ PTING��6)   $ * 68    6B   �� *Rating+  5L      $ DISCRIPTION��6)   $ * 6>    6H   �� *Description+5N      5W      5Z      5[      