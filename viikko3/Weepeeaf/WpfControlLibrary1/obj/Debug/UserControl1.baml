   M S B A M L   `   `   `  ����  WpfControlLibrary1%    WpfControlLibrary1.UserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  ikkuna��5      .��5
   
   �  � ColumnDefinitions 5      �� 5      $	��55* �6#   �� 5      $
��333* �6#   .+�5      �� -   5         ��Name$ vastaus��5   P   $��23��6   $
��Left=�6"   $��	42,72,0,0q�6=   $	��Top=�6a   $	��120��6y   $��2��6�   .��6�   ��5      �� 5       �� ElementName$ ikkuna��6    �� Mode$ OneWay=�63    �� Path$ Laskuri�6A    �� UpdateSourceTrigger$ PropertyChanged=�6P    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      .��5       5      �� 5      -   5        $ kilometrinopeus��5      $
��Left=�6,   $��23��6G   $��	42,13,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��2��6�   .��6�   ��5      �� 5      $ ikkuna��6   $ TwoWay=�6/   $ Laskuri�6=   $ PropertyChanged=�6L    5        5      5      .��5       5!      �� 5#   
   -   5        $
 aika��5#      $
��Left=�6    $��23��6;   $��	42,44,0,0q�6G   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��2��6�   .��6�   ��5$      �� 5%      $ ikkuna��6   $ TwoWay=�6/   $ Laskuri�6=   $ PropertyChanged=�6L    5&        5'      5)      .��5*      5+      �� 5-      -   5        	 ��Name$	 nappula��5-      $��Laske��6&   $
��Left=�66   $��
133,30,0,0q�6Q   $	��Top=�6e   $��75��6}   $��1��6�   5/      �� 50   
   $��Km��6   $
��Left=�6   $��4,10,0,0q�68   $	��Top=�6J   �� 51      $
��Aika��6   $
��Left=�6#   $��4,42,0,0q�6>   $	��Top=�6P   �� 52   
   $
��km/h��6   $
��Left=�6   $��5,72,0,0q�6:   $	��Top=�6L   54      56      