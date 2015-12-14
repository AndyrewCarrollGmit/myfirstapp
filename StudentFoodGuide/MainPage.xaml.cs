using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentFoodGuide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            recipeBook();
        }
        private void recipeBook()
        {
            
            // Pasta Recipe
            textPasta.Text = "Spaghetti & Meatballs";
            textPastaIngredients.Text = "\n\nIngredients:\n\n Spaghetti Pasta \n  MeatBalls \n Bolognese Sauce \n 1 Chopped Onion \n Red and Green Peppers \n ";
            textPastaMethod.Text = "\n Method  \n1: Heat a pan with butter or olive oil\n  \n2: Slowly cook the meatballs until they're fully brown  \n  \n3: While the meatballs are cooking begin chopping your vegtables to add to the meatballs \n \n4: Boil hot water for the spaghetti the size of a two euro coin is the right amout per person \n  \n5: A simple trick to know if the spaghetti is cooked is to throw a piece against the wall, if its sticks then your spaghetti is cooked! \n  \n6: Add the bolognese sauce to the pan and slowly stir  ";

            // Pizza Recipe
            textSoup.Text = "Home-Made Toemato Soup";
            textSoupIngredients.Text = "\n\nIngredients:\n\n One Tablespoon Olive Oil \n 1 chopped Onion \n 1 Celery stick \n Finely sliced garlic \n Tinned tomatoes \n stock cube \n salt & pepper \n  ";
            textSoupMethod.Text = "\n Methods \n 1:Heat the olive oil in a pot and add the chopped onion, celery stick and the garlic \n \n 2: After stirring frequently and beings to soften \n \n3: Add the tinned tomato and stock cube to the pot and stir \n \n4: add the salt & pepper and bring to the boil, stirring occasionsally let it sit for 30/40 minutes before serving";

            // Stir-Fry Recipe 
            textStirFry.Text = "Noodle Stir Fry Dish ";
            textStirFryIngredients.Text = "\n\nIngredients:\n\n Egg Noodles \n Vegtable Mix \n Soy Sauce\n Pieces Of Stripped Beef \n Prawns (Optional)";
            textStirFryMethod.Text = "\n Methods \n 1: Firstly heat a pan or wok and start to cook the pieces of beef \n \n 2: After the beef has been cooked being by adding the stir fry mix which can be bought in any local grocery store, also if you want add the prawns to give the stir-fry an extra flavour \n  \n 3: Boil hot water for the egg noodles which will only take 3-4 minutes to cook \n  \n 4: After the vegtables and prawns have been added and cooked for 4-5 minutes add the egg fried noodles and 4/5 drops of soy sauce \n \n 5: Place onto a heated plate and Enjoy! ";
            
            // Chicken Curry Recipe
            textCurry.Text = "Home-Made Chicken Curry";
            textCurryIngredients.Text = "\n\nIngredients:\n\n A mild curry sauce \n 1 chopped onion \n 1 sliced red & green pepper \n Diced Chicken \n Natural Yoghurt (Optional) \n Sliced green apple \n  White Rice\n  ";
            textCurryMethod.Text = "\n Methods \n 1: Begin by heating up a sauce-pan with vegtable oil \n  \n2: Add the diced chicken to the pan and slowly prepare until chicken is fully cooked \n  \n3: After the chicken is fully cooked begin by adding your onions, peppers and sliced apples \n \n 4: Boil hot water for the white rice and depending on how many you are cooking for add half a cup of rice per person as rice doubles in volume!\n \n 5: Add the Curry sauce to the pan and slowly stir until piping hot \n \n6: If you like add 1/2 dessert spoonfuls of Natural yoghurt and stir in gently.. Enjoy!";

   
         }
              
              
        }

       
    }

