   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   #    StudentInfoSystem.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   � $
��Left=�6   $	��399��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��772��6b   .+�5      �� -   5         ��Name$ UsernameTextBox��5   U   $
��Left=�6n   $��26��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��138��6�   $��153,131,0,0q�6�   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   G� 5      -   5         G�Name$ PasswordTextBox��5      $
��Left=�63   $��27��6N   $	��Top=�6Z   $	��138��6r   $��153,188,0,0q�6~   �� 5      $��	Password:��6   $
��Left=�6(   $	��Top=�6C   $��
87,188,0,0q�6[   $��66��6o   �� 5      $��	Username:��6   $
��Left=�6(   $	��Top=�6C   $��
87,131,0,0q�6[   $��66��6o   �� 5      -   5         ��Name$ LoginButton��5   h   $��Login��6}   $
��Left=�6�   $	��Top=�6�   $��75��6�   $��
93,241,0,0q�6�   ��6   �� *Login+��6/   ��  �� ElementName$ PasswordTextBox��6�   �� 5      -   5        $ NoLoginButton��5   2   $��NoLogin��6I   $
��Left=�6[   $	��Top=�6v   $��75��6�    J� RenderTransformOrigin$ 2.254,12.694&�6�   $��198,241,0,0q�6�   ��6   �� *	NoLogin+6�   5      5      5      