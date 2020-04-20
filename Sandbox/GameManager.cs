﻿using System;
using System.Collections.Generic;
using OpenGE;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Sandbox
{
    public class GameManager : Manager
    {
        //CONSTANTS
        public const string game = "Hello";
        public const int width = 800;
        public const int height = 800;

        //OBJECTS
        private static Font _font = Graphics.LoadFont("default.ttf");
        
        //LISTS
        private List<Button> buttons = new List<Button>();
        private List<Drawable> objects = new List<Drawable>();
        private List<Frame> frames = new List<Frame>();
		
		//AUDIO
        public void Render(RenderWindow window)
        {
            //HANDLE EVENTS
            window.KeyPressed += HandleInput;
            window.MouseButtonPressed += HandleMouseButtonInput;
            window.MouseMoved += HandleMouseInput;
            
            Renderer.Render(window,objects);
            UIRenderer.RenderButtons(window,buttons);
        }

        public void Start()
        {
			//PLAY AUDIO
			
            //OBJECTS
            
            //BUTTONS
            
            //FRAMES
            
            //Run all the GEObject "Start" Methods
        }

        public void Update()
        {
            //Run all the GEObject "Update" Methods
        }
        void HandleInput(object sender, KeyEventArgs e)
        {
            
        }

        void HandleMouseButtonInput(object sender, MouseButtonEventArgs e)
        {
            
        }

        void HandleMouseInput(object sender,MouseMoveEventArgs e)
        {
			
        }
    }
}