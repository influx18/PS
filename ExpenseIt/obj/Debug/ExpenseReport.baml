   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � $��
10,0,10,10q�6   ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��226* �6   .+�5   
   �� $��1��6   ��6    ��  �� RelativeSource ��  �� AncestorType" � �� Path$ MainCaptionText�6�   � 5   
   $��1��6   $
��Left=�6   $	��363��6:   $��	10,10,0,0q�6G   $��1��6Z   $	��Top=�6g   $	��210��6   $��2��6�    5      �� 5      $	��80* �6    �� 5      $	��30* �6    �� 5      $	��30* �6    �� 5      $
��222* �6    .+�53      �� $��1��6   $��	0,0,165,0q�6!   .��64   Name:6;   �� 54      $��1��6   $��50,0,0,0q�6?   ��6!   �� $
 Name�6S   �� 55      $��2��6   $��	0,0,135,0q�6!   .��64   Department:6A   �� 56      $��2��6   $��80,0,0,0q�6E   ��6!   �� $ 
Department�6Y   &   System.Windows.Controls.DataGrid  58      $��3��6      AutoGenerateColumns .     RowHeaderWidth$ 0Q�6f   $��	0,0,0,143q�6y   ��6$   �� $ Expenses�	   Columns	 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ExpenseType��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ ExpenseType�  5;      $
 Amount��6)    69   �� $ ExpenseAmount�5=      5A      5I      5J      