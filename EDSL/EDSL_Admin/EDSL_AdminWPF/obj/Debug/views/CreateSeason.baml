   M S B A M L   `   `   `  ����H  DEDSL_AdminWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EDSL_AdminWPF.viewsEDSL_AdminWPF.views  5      &     EDSL_AdminWPF.views.CreateSeason   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:EDSL_AdminWPF.views     5        N� Title$  CreateSeason��5	      .��5      � .+�5   
   �� $��Start Date:��6   $
��Left=�6&   $��	36,26,0,0q�6A   $	��Top=�6T    J� RenderTransformOrigin$ 0.5,0.5&�6l   $��80��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 	StartDate��5      $
��Left=�6&   $��
121,26,0,0q�6A   $	��Top=�6U   $	��193��6m   �� 5   
   $��Length:��6   $
��Left=�6"   $��
36,330,0,0q�6=   $	��Top=�6Q   $��80��6i   $��29��6t   �� 5   
   -   5         ��Name$ SeasonLength��5      $
��Left=�6(   $��23��6C   $��121,334,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   6�   �� 5   
   -   5         ��Name$ btn_GenerateSeason��5      $��Generate��6-   $
��Left=�6@   $��768,635,0,0q�6[   $	��Top=�6p   $��75��6�   6�   �� 5   
   $��Holidays��6   $
��Left=�6#   $��
520,22,0,0q�6>   $	��Top=�6R   $��89��6j   �� 5   
   -   5         ��Name$ list_Holiday��5      $
��Left=�6)   $	��401��6D   $��
628,10,0,0q�6Q   $	��Top=�6e   $	��227��6}    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ btn_AddHoliday��5      $	��Add��6)   $
��Left=�67   $��
520,53,0,0q�6R   $	��Top=�6f   $��75��6~   6�   5      5      