   M S B A M L   `   `   `  ���� E  APrubaTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PrubaTimer
PrubaTimer      PrubaTimer.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:PrubaTimer     -     � Title$  
Cronometro��$	��382��$	��560�� � 
ResizeMode$ NoResize=�$y�Visible=� � WindowStyle$ SingleBorderWindow=�.���  � ColumnDefinitions �� $��4* ��� $
��319* ��� $	��57* ��� $	��93* ��� $	��72* ��� $	��22* �.+��� $��1��$��5��$��0,0,0,23q�.+��� $	��145��$	��120���� $��
/fondo.jpg��$	��573��$	��384�� �� Left$ -9��	� -   $	��OP1��$��Algoritmo 1��$ 19��
 �� Top$ 14�� d� 	IsChecked$
 TrueY�	� -   $	��OP2��$��Algoritmo 2��$ 19��$ 38���� -   $��
IntTimStap��$
 TrueY�$!��Quitar Interval de TimeSpan��$	 211��$ 75��$	��165���� -    ��Name$ Titulo�� J� IsHitTestVisible$ False��$
��Left=�$��60��$��
208,10,0,0q�$��
Cronometro��	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��173��$��30(�$��1��
������ $��3���� -   $
 Hora��$ False��$
��Left=�$	��145��$��	88,94,0,0q�$��00��$
	 Wrap=�$	��Top=�$	��119��$	��100(�
 J� RenderTransformOrigin$
 -0.414,2.814&�$��1��
������ �� -   $ 	SepHorMin��$ False��$
��Left=�$	��145��$��
208,94,0,0q�$��:��$
	 Wrap=�$	��Top=�$��27��$	��100(�$
 -0.414,2.814&�$��1��
������ �� -   $ Minutos��$ False��$
��Left=�$	��145��$��
236,94,0,0q�$��00��$
	 Wrap=�$	��Top=�$	��119��$	��100(�$
 -0.414,2.814&�$��1��
������ $��2���� -	   $ 	SepMinSeg��$ False��$
��Left=�$	��145��$��	36,94,0,0q�$��:��$
	 Wrap=�$	��Top=�$��27��$	��100(�$
 -0.414,2.814&�$��2��
������ $��2���� -
   $ Segundos��$ False��$
��Left=�$	��145��$��5,94,0,0q�$��00��$
	 Wrap=�$	��Top=�$	��119��$	��100(�$
 -0.414,2.814&�$��3��
������ $��2���� -   $��Start��$��1��$
��Left=�$��78��$��
88,258,0,0q�$	��Top=�$	��119��$��40(�$
 0.5,0.5&� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       �� " ��.���  � ��
 ���� ��  � ��
 �������  � ��$ Comic Sans MS)���  � ��
 ���� �� -    ��Name$ Pause��$��Pause��$��1��$
��Left=�$��78��$��235,258,0,0q�$	��Top=�$	��119��$��40(�$��2���� -   $
 Stop��$
��Stop��$��3��$
��Left=�$��78��$��	5,258,0,0q�$	��Top=�$	��119��$��40(�$��2��� $��1��$
��Left=�$��Center=�