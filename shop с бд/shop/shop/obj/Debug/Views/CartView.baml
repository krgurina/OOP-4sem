   M S B A M L   `   `   `  ����?  ;shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:shop.Views
shop.Views  5      1clr-namespace:shop.ViewModelsshop.ViewModels  6.       shop.Views.CartView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=22.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:shop.Views     5      4
viewmodelsclr-namespace:shop.ViewModels     6.     N� Title$  CartView��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��587* �6   �� 5      $
��213* �6   .+�5   
   �� $��2��6   $��
0,0,0,-0.4q�6(   
CartView6F   �� 5   
   -   5         ��Name$ productList��5   L   $��0��6   $	��300��6�   $��Disabled=�6�   $��
0,0,0,-0.4q�6�    �� SelectedItem 6#   �� *SelectedProduct+��6a   �� *
UserCart+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   $��5q�68   .+�5      �� $ 
Horizontal=�6%   .+�5      �� $	��100��6$   $	��100��60   ��6=   ��  �� Path$ Product.ImageLink��� 5      $��12(�6(   ��66   �� $ Product.Title��� 5      $��-��6%   �� 5      $��12(�6(   ��66   �� *Count+�� 5      $��+��6%   �� 5      ��6(   �� *Price+ �� StringFormat$ {0} BYN���� 5      $��x��6%   5      5      5      ��5"      �� 5#      .R�5$      �  � Orientation$ 
Horizontal=�6    $��Center=�69   $��15q�6V   5%      5'      5(      5)      