   M S B A M L   `   `   `  ����F  BSeahawksApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SeahawksAppSeahawksApp  5          SeahawksApp.OffPlayers   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SeahawksApp     5        � 	Resources  5	         ScaleStyleImage �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� ScaleX �� ScaleY  MyButtonStyle	 �� 
TargetType
 �� Triggers��%)  &	        &	 �     �� 5
   
   " ��6(    5      P� 5       �@J�IsMouseOver . . �5      ��  �@K�ZIndex$ 1��64   �� 5       � z� 5      �� 5      $
 1.05Q�6-   $
 1.05Q�6;   5      5      5      �� 5   
   " ��6&   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��border��6!   #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       
 5!      P� 5"       �@J�IsMouseOver . . �5#   "   ��  �@�Cursor$
 Hand��6;   �� 5$   "    �@K�ZIndex$ 1��6@   �� 5%   "    � z� 5&   &   �� 5'   *   $	 1.2Q�69   $	 1.2Q�6F   5)   #   5*      5,      5.      5/      50      .��52      � 
���   �.+�54   
   �� $
��Left=�6   $	��280��60   $	��Top=�6=   $	��425��6U   .+�55      �� -   5         ��Name$ image��55      #��[  6#    J� RenderTransformOrigin$ 0.5,0.5&�6L   $
��Left=�6l   $	��Top=�6�   $��Files/Players/OFF/2.png��6�   $��	20,40,0,0q�6�   57      �� 59   
   $
��Left=�6   $	��295��60   $��	425,0,0,0q�6=   $	��Top=�6P   $	��293��6h   .+�5:      �� -   5         ��Name$
 name��5:      $
��Wrap=�6&   $��Philip Juhlin��6:   
���   ����	#FFFFCA05 �� TextAlignment$ Center=�6y   $
��Bold"�6�   $��Fragua)�6�   $��48(�6�   $��Center=�6�   $��Center=�6�   $��27,100,27,0q�6�   $	��110��6  �� 5;      -   5        $	 pos��5;      $
��Wrap=�6%   $��Quarterback��69   
���   �
�������$ Center=�6r   $
��Bold"�6�   $��Fragua)�6�   $��36(�6�   $��	30,0,33,0q�6�   $��65��6�   5>      ]� 5?   
   $
��Left=�6   $��78��6/   ��.  $��
10,300,0,0q�6Q   $	��Top=�6e   $	��708��6}   .+�5@      �� -   5        #��[ 5@      $ 0.5,0.5&�6=   $��53��6]   $	��122��6v   $��	130,5,5,5q�6�   ��6�   Z� ��6�   Z� ��5A      �� 5B       �� ImageSource$  Files/Players/PREVIOUS.png��6!   5D      �� 5E      -   5        #��[ 5E      $ 0.5,0.5&�6=   $��53��6]   $	��122��6v   $��Right=�6�   $��5,5,99,5q�6�   ��6�   Z� ��6�   Z� ��5F      �� 5G      $ Files/Players/NEXT.png��6!   5I      5J      5K      5L      