   M S B A M L   `   `   `  ����F  BFileManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileManagerFileManager  5   	       FileManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileManager     5   	     � Title$  File Manager��5   	   $	��450��6   $	��800��6+    � 
ResizeMode$ CanMinimize=�67    � Icon$ 
/files.png��6P   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��32* �6   �� 5      $
��607* �6   �� 5      $
��161* �6   .+�5   
   � -   5        $��header��5   O   $��118,0,0,358q�6   $��2��6$   ���	#FFB2B2B2$��1��6]   .+�5      �� $!��Select a task from the menu��6   $��Center=�6:   $��Center=�6W   ���	#FFB2B2B2
�������$��22(�6�   $
��Bold"�6�   $��Italic$�6�   5      � 5   
   -   5        $��taskBar��5   M   $	��150��6   $
��Left=�6   ���	#FF146AB2$��2��6\   .+�5      �� $��File Manager��6   $
��Left=�6+   $��5,6,0,0q�6F   $	��Top=�6W   ���	#FF146AB2
�������$��22(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5      -   5         ��Name$ 
sortFolder��5      $��Sort Folder��6)   $��Center=�6?   $��	0,101,0,0q�6\   $	��Top=�6o   $��42��6�   
������� � Cursor$
 Hand��6�   
����������	#FF146AB2$��75��6�   6  5      � 5   
   -   5        $��content��5   6   $	��650��6   $
��Left=�6   $��2��6E   $��
118,76,0,0q�6Y   $��1��6m   .+�5      �� $$��Created by G. Yepiskoposyan ©��6   $��25(�6<   $��Arial)�6J   
�������$��142,114,142,114q�6o    J� RenderTransformOrigin$ 0.494,0.653&�6�   6�   5      5      5      