# Seahawks Gdynia 2019 Application

Application showcasing players, history, photos and previews of next games. 

I am making this app to practice WPF possibilities. 

I do not own any rights to any pictures used in app. They are used for educational process. 

## To Do List

~~1.Making PSD files in Photoshop for every window in application.~~  **DONE** *28.03*

~~2.Program PSD into Application.~~ **DONE** *06.04*

~~3.Test the bugs.~~ **DONE** *06.04*

~~4. Deploy~~ **DONE** *06.04*

Version 1.0 *06.04*


5. New Features (Version 2.0)

## 1. Photoshop Files

Made all 5 files. Time To program them.


Home Screen

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20HOME.jpg)

History

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20History.jpg)

Players (Division for def and off)

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20PLAYERS.jpg)

Players_Offensive (Same look as Defensive)

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20PLAYERS_OFFENSIVE.jpg)

Photos

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20PHOTOS.jpg)

Next Game

![Home Screen](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/psd/SEAHWKS%20NEXT_GAME.jpg)


## 2. Programming 

A little bit changed project in process of production. I have added different sizes of fonts, hover effects which caused diffrent placement of containers. 

**Interesting Parts Of Code**

*Button Style*

I did not like the basic hover effect built in the wpf library so i had to chaned it. 
```XAML
...
<ControlTemplate TargetType="Button">
                        <Border Name="border" 
                            Background="{TemplateBinding Background}">
                            <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center" />
                        </Border>
                        <ControlTemplate.Triggers>
                            <Trigger Property="IsMouseOver" Value="True">
                                <Setter Property="Cursor" Value="Hand"/>
                                <Setter Property="Grid.ZIndex" Value="1"/>
                                <Setter Property="RenderTransform">
                                    <Setter.Value>
                                        <ScaleTransform ScaleX="1.2" ScaleY="1.2"/>
                                    </Setter.Value>
                                </Setter>
                            </Trigger>
                        </ControlTemplate.Triggers>
                    </ControlTemplate>
                    ...
```

*Players Carousel*

Used basic switch case to change number of players. Thats how i got them to rotate and do full run from 0 to n where n is equals to number of players. 

*Scroll View*

Changed the basic scroller to my custom one. Code can by found in [this directory](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Resources.xaml).


## 3. Deploy

First deploy. App can be found [this directory](https://github.com/Dajnowicz/Seahawks_Application2019/tree/master/SeahawksApp/Deploy).

![](https://github.com/Dajnowicz/Seahawks_Application2019/blob/master/SeahawksApp/Files/Video/SeahawksApp.gif)

## 4. New Features

For next versions of apps I am planning to do implement these features.
**IDEAS**
- [x]  Different type of Scroller on Photos Section.
- [x]  Add more Photos. 
- [ ]  Add menu in photos section in order to change pictures from different games.
- [x]  Change hover effect on menu. 
- [ ]  Add table with all scores from the league.


