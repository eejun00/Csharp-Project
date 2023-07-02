﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace _2023Maker
{
    public class Art
    {
        //프롤로그 화면
        public void PrintStart()
        {
            string[] art = new string[]
                {
                    
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⢠⣤⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⡀⠀⠀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣶⡿⠛⠛⠛⣿⣾⠟⠛⠛⢿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⣿⣿⣿⣧⣿⣿⣿⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⢹⡇⠀⢿⠟⢹⣷⠀⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⣶⣾⠿⣧⡄⢠⣶⡟⢷⡄⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⠟⠁⠈⠃⠀⠀⠀⠈⠋⠀⠛⢿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⡀⠀⠀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⢠⣤⣿⡿⠀⠿⠇⠈⠉⠀⠸⠇⠰⢿⣿⣯⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣿⡿⠀⠀⣀⣄⠀⠀⠀⢀⣀⠀⠀⠸⣿⣧⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⣿⣿⣿⣧⣿⣿⣿⣿⣿⣤⡄⠀⠀⠀⠀",
"⠀⠀⠀⠀⢸⣿⣿⢠⣶⡄⠀⠀⢀⣶⡆⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⣿⣿⠀⣤⡄⢸⣿⡇⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⠟⠁⣴⣶⣶⣿⡇⢠⣶⣶⣿⣿⡇⠀⠀⠀⠀",
"⠀⠀⠀⢠⣼⣿⣿⠸⣿⠿⠂⠀⠐⢿⡇⠀⠀⠀⢿⣿⣥⡄⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠈⠁⠀⠀⠀⠈⠉⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⣤⣿⡿⠀⠀⠈⠹⣿⠏⠁⠈⠙⢿⣿⣿⡅⠀⠀⠀⠀",
"⠀⠀⢀⣸⣿⡏⠀⠁⠀⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠘⠿⣷⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣾⡿⠟⠀⠀⠀⠀⠀⢰⣾⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⢿⣷⣆⡀⠀⠀⠀⠀",
"⠀⠀⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣿⣿⣿⠀⠀⠀⠀⠀⠀⢸⣿⣿⢁⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣈⢹⣿⣿⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣿⣿⣿⣤⡀⠀⠀",
"⠀⠀⣿⣿⠀⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠋⢸⣿⣿⠀⠀⠀⠀⠀⠀⠘⠿⣷⣾⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣾⡿⠟⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⣿⣿⡇⠀⠀",
"⠀⠀⠛⢻⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡟⠉⠀⠀⠀⠀⠀⠀⢸⣿⣿⣉⣉⣀⣀⣀⣀⣀⣀⣀⣀⣀⣈⣉⣹⣿⣿⠀⠀⠀⠀⠀⢸⣿⣧⡀⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⠀⢿⣿⣤⣤⣿⣿⡇",
"⠀⠀⣶⣾⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⢿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠘⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠟⠀⠀⠀⠀⠀⠀⠈⠿⣿⣶⣶⣶⣶⣾⠟⠁⠀⠀⠀⠀⠀⠘⠛⠛⣿⣿⡇",
"⠀⠀⠙⠛⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠙⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠙⠛⠛⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⣠⣤⣤⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⢠⣤⣤⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣿⠟⠛⠛⢿⣿⠟⠛⠛⢻⣷⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⣿⠟⠛⠛⣿⣾⠟⠛⠛⢻⣷⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⣾⡆⢸⣿⡇⣾⡇⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⣿⠀⣿⣿⠀⣾⡆⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⣿⡇⠘⠛⠁⣿⡇⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⣿⠀⠙⠛⠀⣿⡇⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣿⡿⠀⠈⠀⠀⠀⠀⠀⠀⠸⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡏⠁⠀⠀⠀⣿⣷⠀⠀⢀⣼⣿⡄⠉⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡋⠀⣼⣿⣄⠀⠀⢸⣿⡆⠀⠀⠀⠉⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⢀⣀⠛⠋⠀⠀⠙⠛⠛⢁⡀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⢀⠙⠛⠛⠀⠀⠘⠛⠃⣀⡀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⣷⡆⢰⣶⡀⠀⠀⠀⠀⣶⣦⢠⣶⣿⠿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠹⢿⣷⣦⢠⣶⡄⠀⠀⠀⠀⣴⣦⠀⣶⣿⠿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⢈⣽⣿⡇⠀⢰⣿⣯⣁⠸⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⡿⢀⣩⣿⣷⠀⠀⣿⣿⣅⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⡿⠃⠘⠛⠛⠃⠀⠈⠛⠛⠋⠀⠀⠛⣿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⡟⠃⠀⠘⠛⠛⠋⠀⠀⠛⠛⠛⠀⠛⣿⣶⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
                };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(0, 0+i);
                Console.WriteLine(art[i]);
            }
        }

        public void PrintPrologue()
        {
            string[] art = new string[]
            {
"                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀",
"⠀⠀⠀⠀⣤⡿⠿⠿⢿⣼⠿⠿⠿⣧⡄⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⡟⠿⣿⣷⣶⣾⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀      ",
"⠀⠀⠀⠀⣿⣇⡀⠀⡌⢹⣶⠀⣤⠉⢳⡆⠀⠀⠀⠀⢸⣿⠉⠹⠿⠉⠁⣤⡿⠿⠉⢹⣿⣿⡿⠿⣦⣄⠀⠀⠀⠀⠀⠀⠀      ",
"⠀⠀⠀⠀⠀⣿⡇⠀⡇⠈⠛⠀⣿⠀⢸⡇⠀⠀⠀⠀⠈⣿⣿⢸⣿⣿⡇⠉⣥⣤⢸⣿⣿⡏⠑⣤⣿⣧⡄⠀⠀⠀⠀⠀⠀      ",
"⠀⠀⠀⠀⣿⣿                ⢶⣿⣷⣶⣶⡆⠀⣶⣶⣶⣀⠰⣶⣶⣿⣿⢀⣸⣿⣷⡆⠀⠀",
"⠀⠀⠀⣶⠟⠋⠀⢠⣆⠀ ⠀⣴⡄⢸⣿⣿⡆⠀⣶⡆⠀⣸⣿⠿⠃⠀⣿⣇⠀⠸⠿⢿⣿⣷⣶⣿⣿⣿⣿⣿⠀⠀⠀⠀     ",
"⠀⠀⠀⣿⠀⠀⠀⠘⠓⠀⠚⠀⠛⠃⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⣼⣿⣿⣿⣿⣿⣤⣼⣿⣯⡿⠿⣿⣿⣿⠁⠀⠀⠀⠀     ",
"⠀⠀⠀⣿⣄⡀⠀⠀⢀⣀⣀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣀⠀⠀⠀⠀     ",
"⠀⠀⠀⠀⠛⣿⣾⠉⢜⣻⣿⠅⠀⠀⠸⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀    ",
"⠀⠀⠀⠀⣴⡿⠿⠌⠘⠛⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀     ",
"⠀⠀⠀⠀⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠋⠁           "
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(20, 24+i);
                Console.WriteLine(art[i]);
            }
        }

        public void PrintPrologue2()
        {
            string[] art = new string[]
                {

"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣶⣶⣦⠀⠀⢰⣶⣶⣶⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣾⡿⠛⠛⣿⣿⣿⣿⠟⠛⠛⠛⢿⣷⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⠋⢳⣦⠀⣿⣿⡟⠙⣶⠀⠀⢀⣸⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⢸⣿⠀⠻⡿⠇⠀⣿⠀⢰⣿⣿⡋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣾⡿⠟⠀⠘⠋⠀⠀⠀⠀⠀⠛⠀⠘⠿⣿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⢠⣶⡄⠀⠀⠀⠀⣶⣦⠀⠀⠀⠀⣸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠋⠀⢸⣿⣿⡦⠀⠀⠀⣿⣿⠀⠀⠀⠀⠈⠙⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⣷⣶⣶⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠻⣿⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣸⣿⣿⡛⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣏⣹⣿⣧⣰⣿⣧⣠⣿⣿⣀⣀⣀⣀⣀⣀⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
                };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(20, 23+i);
                Console.WriteLine(art[i]);
            }
        }

        //처음 토끼
        public void PrintFirstRabbit()
        {
            string[] art = new string[]
        {
            "⠀⠀⠀⣠⣶⣶⣄⣴⣶⣦⡀⠀⠀",
            "⠀⠀⠀⣿⠀⡄⢸⡇⢠⠀⡇⠀⠀",
            "⠀⠀⣀⠿⠀⠇⠈⠁⠸⠀⢇⡀⠀",
            "⠀⣀⠿⠀⢀⡀⠀⠀⣀⠀⠸⢇⡀",
            "⠀⣿⠀⠀⠸⠇⠐⠀⠿⠀⠀⢸⡇",
            "⠀⠻⣤⠀⠀⠀⠀⠀⠀⠀⢠⡼⠃",
            "⠀⠀⣿⠀⢳⣼⡇⣾⣤⠓⢸⡇⠀",
            "⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀",
            "⠀⠀⠛⣤⢠⣤⣤⣤⣤⠀⡜⠃⠀",
            "⠀⠀⠀⠈⠛⠃⠀⠀⠛⠛⠀⠀⠀"
        };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(36, 26+i);
                Console.WriteLine(art[i]);
            }
        }

        //하트출력
        public void PrintHeart()
        {
            string[] art = new string[]
        {
    "⠀     ⡶⠶⠶⢶⣄⠀⠀⢀⡶⠶⠶⠶⣆⡀⠀⠀⠀⠀",
    "⠀⠀⠀⣠⡶⠋⠀⠀⠀⠀⠹⢷⣴⠟⠁⠀⠀⠀⠉⠷⣦⠀⠀⠀",
    "⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠈⠁⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀",
    "⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀",
    "⠀⠀⠀⠉⠿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⡿⠋⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠉⠿⣤⠀⠀⠀⠀⠀⠀⠀⠀⣠⡿⠋⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠙⢻⣤⠀⠀⠀⠀⣠⡾⠋⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢻⣆⢠⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
        };
            for (int i = 0; i < art.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 20+i);
                Console.WriteLine(art[i]);
                Console.ResetColor();
            }
        }

        //음표 출력
        public void PrintNote()
        {
            string[] art = new string[]
        {
            "⠀⠀  ⢀⣀⣤⣤⣶⣶⡆",
            "⠀⠀⣴⡿⠿⠛⠋⠉⣁⣿⡇",
            "⠀⠀⣿⣧⣶⣶⡿⠿⠟⣿⡇",
            "⠀⠀⣿⡏⠁⠀⠀⢀⣀⣿⡇",
            "⠀⣀⣿⡇⠀⠀⢠⣿⣿⣿⡇",
            "⣾⣿⣿⡇⠀⠀⠈⠻⠿⠟⠀",
            "⠙⠿⠿⠃⠀⠀⠀⠀⠀⠀⠀"
        };

            for (int i = 0; i < art.Length; i++)
            {
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.SetCursorPosition(60, 10+i);
                Console.WriteLine(art[i]);
                Console.ResetColor();
            }

        }

        //폭죽 출력
        public void PrintFireCracker()
        {
            string[] art = new string[]
            {
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠿⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣿⠟⠀⠀⢠⣤⡄⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣿⠛⣀⣼⣿⡟⠃⠀⠀⠀⠀⠀⠀⠀⠈⠻⠷⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣾⡟⣁⣶⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⣶⣶⣀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⢠⣤⣴⣾⡏⣷⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠀⠀⠀",
    "⠀⠀⠀⠀⠀⣼⡿⢩⣽⣯⣽⣿⡍⠀⣀⣤⣤⣴⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣶⡿⠃⠸⢿⣿⣤⣭⣿⡿⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⣶⡟⠃⠀⠀⠀⠙⠛⣃⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⣶⡟⠁⠀⠀⢠⣤⣶⣷⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⣾⡿⠁⣤⣼⡿⠿⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⢸⣿⡿⠿⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
            };

            string[] art2 = new string[]
            {
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⠿⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⢠⣤⡄⠀⠀⠻⣿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠾⠟⠁⠀⠀⠀⠀⠀⠀⠀⠘⢻⣿⣧⣀⠛⣿⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⣀⣶⣶⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣶⣈⢻⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣾⢹⣷⣦⣤⡄⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣦⣤⣤⣀⠀⢩⣿⣯⣽⣯⡍⢿⣧⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠛⢿⣿⣭⣤⣿⡿⠇⠘⢿⣶⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣘⠛⠋⠀⠀⠀⠘⢻⣶⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣾⣶⣤⡄⠀⠀⠈⢻⣶⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠿⢿⣧⣤⠈⢿⣷⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠿⢿⣿⡇",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀"};
            for (int i = 0; i < art.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(7, 6+i);
                Console.WriteLine(art[i]);
            }

            for (int i = 0; i < art2.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(48, 6+i);
                Console.WriteLine(art2[i]);
                Console.ResetColor();
            }

        }

        //당근 출력
        public void PrintCarrot()
        {
            string[] art = new string[]
            {
                "⠀⠀⠀⠀⠀⢀⣀⠀  ",
                "⠀⠀⠀⠀⣀⣸⡿⠿ " ,
                "⠀⠀⠀⢰⣿⣿⡇  " ,
                "⠀⠀⢸⣿⣿⠟⠃  ",
                "⠀⠀⠘⠛⠉     "
            };

            for (int i = 0; i < art.Length; i++)
            {
                if (i < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(55, 20+i);
                    Console.WriteLine(art[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(55, 20+i);
                    Console.WriteLine(art[i]);
                    Console.ResetColor();
                }
            }
        }

        //휴식 메인화면 완성
        public void PrintSleep()
        {
            string[] phrase = new string[] {
                "/**////**      /**/////      **////////    /////**///",
                "/**   /**      /**           /**               /**   ",
                "/*******       /*******      /*********        /**    ",
                "/**///**       /**////       ////////**        /**",
                "/**  //**      /**                  /**        /**   ",
                "/**   //**     /*******      *********         /**   ",
                "//     //      ////////      ////////           //",
            };

            string[] art = new string[]
        {
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠸⠿⠿⠿⣇⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⢀⣰⣶⣶⣶⣶⣋⠁⠀ ⣶⠀⠉⢳⡆⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⣤⣿⡇⠀ ⣶⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠉⠉⠁⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⣶⡟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⠛⠛⠛⣶⡄⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠇⠀"
        };
            for (int i = 0; i<phrase.Length; i++)
            {
                Console.SetCursorPosition(15, 9+i);
                Console.WriteLine(phrase[i]);
                Thread.Sleep(50);
            }

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(28, 27+i);
                Console.WriteLine(art[i]);
            }
        }

        //휴식 진행화면 완성
        public void PrintZ()
        {
            string[] z = new string[]
            {
                " ******",
                "////**",
                "   **",
                "  **",
                " ******",
                "//////"
            };

            string[] bigZ = new string[]
            {
                " ********",
                "//////**",
                "     **",
                "    **",
                "   **",
                "  **",
                " ********",
                "/////////"
            };
            for (int i = 0; i < z.Length; i++)
            {
                Console.SetCursorPosition(55, 26+i);
                Console.WriteLine(z[i]);
            }
            Thread.Sleep(500);
            for (int i = 0; i < bigZ.Length; i++)
            {
                Console.SetCursorPosition(65, 19+i);
                Console.WriteLine(bigZ[i]);
            }
        }

        //성장한 토끼
        public void PrintSecondRabbit()

        {
            string[] art = new string[]
        {
            "⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⡀⠀⢀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣀⡼⠿⠿⠿⠿⢿⣀⡼⠿⠿⠿⠿⢧⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣿⡇⠀⢀⣀⠀⢸⣿⡇⠀⢀⡀⠀⢸⣿⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣿⡇⠀⢸⣿⠀⢸⣿⡇⠀⢸⡇⠀⢸⣿⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣿⡇⠀⢸⣿⠀⠈⠛⠃⠀⢸⡇⠀⢸⣿⠀⠀⠀",
            "⠀⠀⠀⠀⣶⣾⠉⠁⠀⠈⠉⠀⠀⠀⠀⠀⠈⠁⠀⠈⠉⣷⠀",
            "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀",
            "⠀⠀⢸⣿⠀⠀⠀⠀⠀ ⣿⠀⠀⠀⠀⠀ ⣿⠀⠀⠀⠀⠀⣿",
            "⠀⠀⢸⣿⠀⠀⠀⠀⠀ ⣿⠀⠀⠿⠀  ⣿⠀⠀⠀⠀⠀⣿",
            "⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇ ",
            "⠀⠀⠸⠿⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⠿⠇ ",
            "⠀⠀⠀⠀⣿⣿⠀⢠⣤⡄⠀⣤⡄⠀⢠⣤⠀⠀⣤⡄⠀⣿⣿⠀⠀",
            "⠀⠀⠀⠀⣿⣿⠀⠘⠛⣧⣤⣿⡇⠀⢸⣿⣤⣤⠛⠃⠀⣿⣿⠀⠀",
            "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠙⠛⠛⠋⠀⠘⠛⠛⠋⠀⠀⠀⣿⣿⠀⠀",
            "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀",
            "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠈⣿⡇⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⠀⢸⣿⠏⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿⠀⠀⠀⠀⠀  ⢿⣿⣿⡇⠀⠀"
        };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(28, 17+i);
                Console.WriteLine(art[i]);
            }
        }

        //점프하는 토끼
        public void PrintJumpRabbit()
        {
            string[] art = new string[]
        {
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⡄⢠⣤⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣸⠿⣉⠉⢹⣿⠉⣉⡉⢹⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⡞⢻⣤⠛⣶⡞⢛⣤⠛⣷⡞⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡿⠇⠸⠿⠀⠈⠁⠘⠿⠀⠿⢇⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠿⠀⢸⣷⠀⠀⠀⢸⣿⠀⠀⠀⠸⢿⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⢸⣷⣶⠀⠀⢸⣿⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣶⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢹⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡿⠿⠿⠀⠀⠀⠀⠀⠀⣤⡼⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⠿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⣶⡏⢱⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠻⣤⣤⡄⠀⠀⠀⠀⠀⠀⠀⠛⠃⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⢱⣶⣶⣶⣶⣶⣶⣶⣶⣶⡎⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "                                               ",
            "                ⣶⣶   ⣶⣶                     ",
            "                ⣶⣶   ⣶⣶                     "
        };


            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 10+i);
                Console.WriteLine(art[i]);
            }
            PrintNote();
        }

        //책상 토끼
        public void PrintStudyRabbit()
        {
            string[] art = new string[]
            {
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣾⣿⣿⣷⣀⣀⣼⣿⣿⣿⣿⣆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣼⡿⠏⠀⠀⢹⣿⡿⠏⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⡇⠀⢸⣿⠀⠀⣿⠀⢠⣴⡿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⠀⠀⠇⠀⠈⠉⠀⠀⠿⠀⢸⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣼⠿⠃⠀⣤⡄⠀⠀⠀⠀⣤⡄⠀⠀⠀⠀⠛⢿⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⣿⣿⠀⠀ ⠀⣿⣿⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠄⠀⠀⠉⠁⠀⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⡀⠀⠿⣿⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⠀⠀⣠⣼⣿⣿⣿⣿⣿⣿⣤⡀⢸⣿⡇⠀⣤⡄⠀⠀⠀⠀⣤⡄⠀⣤⡄⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠀⠀⠀⢠⣶⣿⣿⣿⣿⣿⣿⣿⡿⠉⢱⣾⣿⣷⣾⣿⣷⣶⣶⣶⣶⣿⣿⣶⣿⣿⣶⣿⣿⣷⣶⣶⣶⣶⣶⣶⡄⠀",
"⠀⠀⠀⠀⠀⢸⣿⡿⠿⠿⠿⠿⠿⠁⣀⣾⣿⠉⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⢋⣹⣿⣿⣿⡇⠀",
"⠀⠀⠀⠀⣠⣼⣿⣄⣀⣀⣀⣀⣀⣼⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣾⣿⣿⣿⠿⠃⠀⠀⠀⠀",
"⠀⠀⢠⣴⡿⠟⠀⠻⠿⠿⠿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣶⣿⣿⠿⣿⣿⠀⠀⠀⠀⠀⠀",
"⠀⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀",
"⠀⠿⢿⣿⣿⣿⣿⣿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⠿⠃⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⢸⣿⣿⣾⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣶⣿⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
"⠀⠀⠈⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠉⠉⠉⠉⠁             "
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(22, 18+i);
                Console.WriteLine(art[i]);
            }

        }

        //ing 출력
        public void PrintAIng()
        {
            string[] phrase = new string[]
            {
               "  **           ****     **           ********                       ",
               " /**          /**/**   /**          **//////**                      ",
               " /**          /**//**  /**         **      //                       ",
               " /**          /** //** /**        /**                               ",
               " /**          /**  //**/**        /**    *****                      ",
               " /**          /**   //****        //**  ////**     **     **     ** ",
               " /**          /**    //***         //********     /**    /**    /** ",
               " //           //      ///           ////////      //     //     //  "
            };
            for (int i = 0; i < phrase.Length; i++)
            {
                Console.SetCursorPosition(10, 7+i);
                Console.WriteLine(phrase[i]);
            }

        }

        //봉사 토끼
        public void PrintVolunteer()
        {
            string[] art = new string[]
            {
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⣤⣄⠀⠀⠀⠀⢀⣴⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣼⠿⠿⠿⢿⣷⣤⣤⣤⣿⠿⠿⠿⠿⠿⠿⣿⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣿⡟⠀⠀⠀⠀⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⢹⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⣿⣿⡇⠀⠀⣿⡇⠀⠀⣿⣿⡏⠀⠀⣿⡇⠀⠀⠀⣀⣼⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⡇⠀⠀⣿⡇⠀⠀⣿⣿⡇⠀⠀⣿⡇⠀⠀⣾⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⣿⡇⠀⠀⠈⠉⠀⠀⠀⣿⡇⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣴⣶⠟⠋⠁⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠉⠛⣿⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣴⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⣷⣤⡀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⠀⠀⠀⠀⣿⣿⣷⠀⠀⠀⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀  ⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⡀⠀⠀⠀⠈⠉⠉⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣷⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣶⡆⠀⠀⠀⠀⠀⠀⠀⠀⣰⣶⣿⡟⠋⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⠀⢀⣴⣾⡿⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣾⣿⣿⠃⠀⣠⣤⣤⣀⣼⣿⣿⣧⣤⣄⣀⣀⣀⣀⣀⣀⣀⣠⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀",
      "⠀⠀⠀⠀⣀⣀⣠⡿⠿⠿⠿⣿⣿⣿⣄⣠⣿⣿⣿⠿⢿⣿⣿⣿⣿⡿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⢿⣀⠀⠀⠀⠀⠀",
      "⠀⠀⢰⣿⣿⣿⡿⠀⠀⠀⠀⠸⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⢆⠀⠀⠀⠀",
      "⢰⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣷⡄⠀⠀⠀",
      "⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀",
      "⠀⠙⢱⣶⣶⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣶⣶⣶⡞⠛⠀⠀⠀",
      "⠀⠀⢸⣿⣿⡿⠿⣦⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣼⠿⢿⣿⣿⡇",
      "⠀⠀⢸⣿⣿⡀⠀⠿⢿⣿⣿⣿⡿⠿⣿⣿⣿⣿⡿⠿⣿⣿⣿⣿⠿⢿⣿⣿⣿⣿⠿⢿⣿⣿⣿⡿⠿⠀⢀⣿⣿⡇",
      "⠀⠀⢸⣿⣿⡇⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀",
      "⠀⠀⣸⣿⣿⡇⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠀⠀⠀⢸⣿⣿⣇⡀⠀⠀",
      "⢸⡟⣿⣿⣿⠃⠀⠀⠠⣿⣿⣿⠄⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⡿⠀⠀⠀⢸⣿⣿⡟⠛⣆",

            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(22, 10+i);
                Console.WriteLine(art[i]);
            }
        }

        //성장 과정 출력
        public void PrintGrowUP()
        {
            ConsoleScreen screen = new ConsoleScreen();
            Script script = new Script();
            for (int i = 0; i < 4; i++)
            {
                PrintFirstRabbit();
                Thread.Sleep(300);
                screen.ClearOver();
                PrintSecondRabbit();
                Thread.Sleep(300);
                screen.ClearOver();
            }
            for (int i = 0; i < 6; i++)
            {
                PrintFirstRabbit();
                Thread.Sleep(100);
                screen.ClearOver();
                PrintSecondRabbit();
                Thread.Sleep(100);
                screen.ClearOver();
            }
            for (int i = 0; i < 10; i++)
            {
                PrintFirstRabbit();
                Thread.Sleep(50);
                screen.ClearOver();
                PrintSecondRabbit();
                Thread.Sleep(50);
                screen.ClearOver();
            }
            PrintSecondRabbit();
            Console.SetCursorPosition(20, 41);
            script.PrintOneAtTime(script.growUp);
            screen.ClickNext();
            screen.ClearUnder();
        }

        //엔딩 부분

        //왕 엔딩
        public void PrintKing()
        {
            string[] art3 = new string[]
                { 
"⠀⠀⠀⠀⠀⠀⠀⢠⣤⣤⣤⣤⣤⠀⠀⠀",
"⠀⠀⠀⠀⣠⡟⠛⠛⠛⠛⠀⠀⠀⠙⠛⣿⣥⣤⠀⠀",
"⠀⠀⠀⣾⡇⠀⠀⠀⠀⠀⢠⣼⡇⠀⠀⢀⣀⡈⠻⣄⠀",
"⠀⠀⢠⡟⠃⠀⠀⠀⠀⠀⠀⠘⠛⠃⠀⠀⣤⣤⢀⣿⠀",
"⠀⠀⢘⣿⡇⠀⠀⠀⠀⠀⠠⣼⡟⠃⠀⠠⠀⠀⠛⣦⠀⠀",
"⠀⠀⢸⣧⣤⣴⣿⣶⣿⣤⣤⣾⣷⣤⣤⣤⣤⣤⣴⠛  "
                };                                      

            string[] art2 = new string[]
                {
    "⠀⠀⠀⠀ ⠀⠀⢠⣤⣤⣤⡄⠀⠀⠀",
    "⠀⠀⠀⣤⣬⣿⠟⠋⠉⠉⠉⠛⠛⠛⠛⢻⣤",
    "⡄⣤⠟⢁⣀⡄⠀⠀⢸⣧⡄⠀⠀⠀⠀⠀⢸⣿⠀",
    "⣿⡃⣤⣤⠀⠀⠘⠛⢫⠀⠀⠀⠀⠀⠀⠘⢻⣄⠀",
    "⠀⣼⠟⠡⠤⠄⠀⠘⢻⣷⡄⠀⠀⠀⠀⠀⢸⣿⡋⠀⠀",
    "⠀⠛⣶⣶⣶⣶⣶⣶⣾⣷⣶⣶⣿⣶⣿⣶⣶⣾⡿⠀"
                };

            string[] art = new string[]
                {
            "⠀⠀⠀⠀⠀⠀⠀⠀⣴⣶⣶⣶⣶⣆⢠⣶⣶⣶⣶⣶⡀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⢰⣿⡟⠉⠉⠉⠙⣿⣿⠋⠉⠉⠉⢹⣿⣷⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⢰⡄⠀⣿⣿⠀⠀⣶⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⢸⡇⠀⠿⠿⠀⠀⣿⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⢀⣤⣾⠿⠃⠀⠘⠁⠀⠀⠀⠀⠀⠋⠀⠘⠻⣿⣦⡄⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⠀⣾⣿⠟⠁⠀⠀⠀⣶⣦⠀⠀⠀⠀⢰⣶⡄⠀⠀⠈⠙⣿⣷⡀⠀⠀⠀",
            "⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⣿⡿⠀⠠⠆⠀⢸⣿⠇⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀",
            "⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀",
            "⠀⠀⠀⠻⢿⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣴⣿⠟⠁⠀⠀⠀",
            "⠀⠀⠀⠀⢸⣿⣿⠀⣴⣶⠀⢠⣶⡄⢀⣶⡆⠀⣴⣦⠀⣿⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⠀⣾⣿⣿⣿⠀⠈⠹⣿⣿⣿⡇⠸⣿⣿⣿⠟⠁⠀⢿⣿⣿⣷⡀⠀⠀⠀",
            "⠀⠀⠀⢿⣿⣋⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣈⣿⣿⠃⠀⠀⠀",
            "⢀⣠⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⡀⠀⠀",
            "⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⠀",
            "⣿⣿⡗⢰⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣷⣾⣿⣿⣿⠖⣿⣿⠀",
            "⠈⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠉⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⢻⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⡧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
                };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(27, 14+i);
                Console.WriteLine(art[i]);
            }

            for (int i = 0; i < art2.Length; i++)
            {
                Console.SetCursorPosition(60, 30+i);
                Console.WriteLine(art2[i]);
            }

            for (int i = 0; i < art3.Length; i++)
            {
                Console.SetCursorPosition(6, 30+i);
                Console.WriteLine(art3[i]);
            }
        }

        //용사 엔딩
        public void PrintHero()
        {
            string[] art = new string[]
   {"⠀⠀⠀ ⠀⠀⠀⣾⣿⣿⣿⣿⡆⠀⠀ ⣿⢸⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀  ⠀⢸⣿⡇⠀⠀⢀⣀⣿⣿⣿⡇⠀⢀⣸⣿⣇⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀ ⠸⠿⣧⣤⠀⢸⣿⠀⢸⣿⡇⠀⣿⣿⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⣤⣤⣤⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⢸⣿⠀⠘⠿⠇⠀⣿⣿⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⣿⣿⣿⣧⠀",
    "⠀⠀⠀⠀⠀⢰⣶⡟⠛⠀⠈⠛⠀⠀⠀⠀⠀⠙⠋⠀⠘⠛⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀   ⣿⣿⣿⣿⣿⠀",
    "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀  ⣿⣿⣿⣿⣿⣿⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⣀⡀⠀⠀⢸⣿⡇⠀⠀⠀⠀⢀⣀⣿⣿⣿⣿⣿⣿⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⣀⣸⣿⡇⠀⠀⢸⣿⡇⠀⠀⢀⣀⣿⣿⣿⣿⣿⡿⠿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⢀⣀⡀⠿⠿⠀⠀⠀⠛⠻⠿⢇⣀⣀⣸⣿⡇⠀⣤⣼⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠛⢻⣶⡄⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⢠⣤⣾⣿⣿⠛⠿⣧⣶⣿⣿⣿⣿⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⢰⣶⣶⣾⣿⣿⣿⣿⣿⣶⣿⣿⣿⣿⡏⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠉⠁⠀⠀⠀⠀⣿⣿⣀⣈⣉⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⣀⣀⣿⡿⠀⠀⠀⣀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⣿⣿⣤⣤⣤⣤⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣼⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠛⠛⠛⠛⠛                           ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            };
            string[] art2 = new string[]
                {
            "⠀⠀⠀⠀⠸⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠸⠿⠀⠀⠀⠀⠸⠿⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⢠⣤⣿⡇⠀⠀⠀⠀⠀⠀⠀⢠⣤⣤⡄⠀⠀⠀⠀⠀⠀⣿⣧⣤⠀⠀⠀⠀",
            "⠀⠀⢸⣿⠉⢱⣶⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⢰⣦⠉⢹⣿⠀⠀⠀⠀",
            "⠀⠀⢸⣿⠀⠈⠉⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⠈⠉⠀⢸⣿⠀⠀⠀⠀",
            "⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⣤⡜⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⣤⡄⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⣿⣧⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣿⡇⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀⠀⠀"
                };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(8, 21+i);
                Console.WriteLine(art[i]);
            }

            for (int i = 0; i < art2.Length; i++)
            {
                Console.SetCursorPosition(50, 24+i);
                Console.WriteLine(art2[i]);
            }
        }

        //불량배 엔딩
        public void PrintBlackGuard()
        {
            string[] art = new string[]
                {
                    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⡄⠀⣤⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠛⠛⣻⣿⣿⡟⢛⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⣿⣦⠀⣿⠀⣿⡇⢸⡇⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣶⣿⠟⠀⠛⠀⠈⠀⠘⠃⠸⢿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣾⠟⠁⠛⣿⣷⣦⢰⣾⣿⠟⠁⠛⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠻⠏⠙⠋⠙⠿⠃⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣿⣿⣿⣿⣿⠟⣁⣀⣀⡀⠀⠀⢀⣀⣀⣀⠛⣿⣿⣿⣿⣿⣆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⢰⣶⡿⠋⠀⠀⠀⠀⠀⠻⠿⠿⣷⣆⢠⣾⠿⠿⠿⠃⠀⠀⠀⠀⠘⢻⣷⣦⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢠⣼⡿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣤⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⢸⣿⡋⠀⠀⠀⢀⣀⠀⠀⠀⠀⠀⠀⣀⣼⣿⣀⠀⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠙⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⢰⣾⠟⠁⠀⢀⣴⣿⣿⣶⢠⣶⣶⣶⣶⣿⣋⣘⣻⣶⣶⣶⣶⡆⣴⣾⢿⣶⣀⠀⠀⠛⣿⣶⠀⠀⠀⠀⠀",
    "⠀⠀⢸⣿⠀⠀⠀⣿⣿⠉⢿⣿⣤⠈⠉⠉⠉⠻⢿⣿⠟⠉⠉⠉⠉⣤⣿⡿⠈⢹⣿⡆⠀⠀⣿⣿⠀⠀⠀⠀⠀",
    "⠀⠀⢸⣿⠀⠀⠀⠿⣿⣿⣤⣸⣿⣤⡀⠀⠀⠾⣿⣿⡿⠀⠀⠀⣠⣿⣿⣤⣼⣿⡿⠃⠀⠀⣿⣿⠀⠀⠀⠀⠀",
    "⠀⠀⢸⣿⣀⠀⠀⣶⣆⣿⣿⠇⢸⣿⡇⠀⠀⢶⣿⣿⣶⠀⠀⠀⣿⣿⠀⣿⣿⣰⣶⠄⠀⣀⣿⣿⠀⠀⠀⠀⠀",
    "⠀⠀⠈⠹⢿⣶⣶⣶⣿⠿⠉⠀⢸⣿⡇⠀⠀⣴⣶⣶⣦⡀⠀⠀⣿⣿⠀⠈⠹⢿⣷⣶⣶⣿⠿⠉⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠈⠉⠉⠉⠉⠀⠀⢠⣼⡿⠃⠀⣿⣿⠉⠉⢹⣿⠆⠀⠿⣿⣤⠀⠀⠈⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⠛⠀⠀⠘⢻⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
                };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 18+i);
                Console.WriteLine(art[i]);
            }
        }

        //은둔 엔딩
        public void PrintHermit()
        {
            string[] art = new string[]
                {
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⠏⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣏⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⠋⠁⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠈⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⠟⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠘⢿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤"
        };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(4, 17+i);
                Console.WriteLine(art[i]);
            }
        }

        //용병 엔딩
        public void PrintMercenary()
        {
            string[] art = new string[]
            {
                "⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⣠⣶⠛⠛⠛⠛⠛⣷⣦⠀⠀⠀⢀⣿⣿⣿⣿⣿⣇⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⣿⣿⠀⠀⢀⠀⠀⣿⣿⣶⠀⢰⣿⡇⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⣿⣿⠀⠀⢸⠀⠀⢿⣿⣿⡀⣸⣿⡇⠀⢸⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢀⣿⡿⠀⠀⠸⠀⠀⠀⠸⣿⣿⣿⠟⠁⠀⢸⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠸⣿⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣉⣷⡶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢀⣤⡿⠟⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⣀⡀⠀⠸⠿⣧⣄⠀⠀⠀⢀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⢀⣿⣷⠀⠀⠀⣿⣿⠀⢀⣤⡾⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⣧⣄⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠙⠋⠀⠀⠈⠀⠈⠛⠋⠀⠀⠀⣿⣿⠀⢸⣿⣷⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢸⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⢸⣿⡿⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⣿⣿⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠈⠙⣷⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣾⣿⣿⣿⣿⣿⡇⠀⠀⢰⣾⣿⣿⣿⣿⣿⣿⣶⠏⠁⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢸⣿⡋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢘⣿⣿⣿⣇⣀⣀⣸⣿⣏⠉⣿⡿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠸⣿⣇⣠⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢿⣿⣿⠁⠀⠀⠻⠿⠿⠿⠿⠿⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⣿⣿⡿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⣿⣿⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣴⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 20+i);
                Console.WriteLine(art[i]);
            }
        }

        //톱스타 엔딩
        public void PrintTopstar()
        {
            string[] art = new string[]
            {"⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⡆⠀⠀⢸⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⢀⣀⣿⣿⣿⡇⠀⢀⣸⣿⣇⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠸⠿⣧⣤⠀⢸⣿⠀⢸⣿⡇⠀⣿⣿⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣤⣤⡀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⢸⣿⠀⠘⠿⠇⠀⣿⣿⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣿⣿⣿⣿⣿⣧⣤⠀",
    "⠀⠀⠀⠀⠀⢰⣶⡟⠛⠀⠈⠛⠀⠀⠀⠀⠀⠙⠋⠀⠘⠛⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⠀",
    "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⣀⡀⠀⠀⢸⣿⡇⠀⠀⠀⠀⢀⣀⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⣀⣸⣿⡇⠀⠀⢸⣿⡇⠀⠀⢀⣀⣿⣿⣿⣿⣿⡿⠿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠀⠀⠀⢀⣀⡀⠿⠿⠀⠀⠀⠛⠻⠿⢇⣀⣀⣸⣿⡇⠀⣤⣼⣿⣿⣿⣿⡿⠿⠃⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠛⢻⣶⡄⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⢠⣤⣾⣿⣿⠛⠿⣧⣶⣿⣿⣿⣿⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⢰⣶⣶⣾⣿⣿⣿⣿⣿⣶⣿⣿⣿⣿⡏⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣿⣿⠉⠁⠀⠀⠀⠀⣿⣿⣀⣈⣉⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⣀⣀⣿⡿⠀⠀⠀⣀⣸⣿⣿⣿⣿⣿⣿⣿⠿⢇⣀⠿⢿⣿⣿⣿⣿⣿⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⣿⣿⣤⣤⣤⣤⣤⣿⣿⣿⣿⣿⣿⣿⠿⠿⣤⡼⠿⣤⣼⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠛⠛⠛⠛⠛⣿⣿⣿⣿⣿⣿⣿⣿⡟⠛⣤⣤⠛⢣⣤⣿⣿⣿⡟⠛⠛⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⠉⢱⣶⠉⠙⣶⣾⣿⣿⣿⠛⣷⣶⣿⣿⣿⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣶⡎⠉⣶⣾⣿⣿⣿⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⢻⣿⣿⣿⣿⣿⠛⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",

            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 15+i);
                Console.WriteLine(art[i]);
            }
        }

        //할렘 엔딩
        public void PrintHarlem()
        {
            string[] art = new string[]
            {
                "⠀⠀⠀⠀⠀⣀⣤⣤⣤⣠⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣄⣤⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣀⣤⣤⣄⡀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⣿⣁⢠⡟⣿⠁⡜⣷⡆⠀⠀⠀⠀⠀⠀⠀⣿⢠⡄⣿⠁⡄⣿⡇⠀⠀⠀⠀⠀⠀⣶⠛⡄⢹⡟⣧⢀⣿⡇⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⣿⠘⠃⠉⠀⠇⣿⡇⠀⠀⠀⠀⠀⠀⣤⠿⠘⠃⠉⠀⠇⠻⣧⡀⠀⠀⠀⠀⠀⣿⡀⠇⠈⠁⠛⢸⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⢀⣿⠁⠀⢀⠀⠀⢀⠈⣿⣇⠀⠀⠀⠀⣴⣿⣿⣿⡿⣿⣿⣿⡿⠻⣧⠀⠀⠀⢀⣾⡏⡀⠀⠀⢀⠀⠀⢿⣇⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣿⡇⠀⠀⠼⠇⠀⠾⠇⢀⣿⠀⠀⠀⠀⢿⣇⠛⠋⠈⣀⣛⣻⠆⠀⣿⠀⠀⠀⢸⣇⠀⠿⠆⠀⠿⠀⠀⠀⣿⡇⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠻⣧⠀⠀⠀⣤⢾⡿⣦⣬⡿⠀⠀⠀⢠⡾⠋⠀⠀⠀⠉⠉⠁⠀⠾⣯⠀⠀⠀⠸⣯⣤⢾⣿⢦⡀⠀⠀⣠⡿⠇⠀⠀⠀⠀",
    "⠀⠀⠀⢀⣴⠟⠀⠀⠀⠀⠀⠁⢿⣏⠀⠀⠀⠀⢸⣷⣿⠀⠀⠀⠀⠀⠀⢾⣶⣟⠀⠀⠀⠀⢈⣿⠄⠀⠀⠀⠀⠀⠙⣷⣄⠀⠀⠀⠀",
    "⠀⠀⠀⢸⣷⣶⣶⣶⣶⣶⣶⣶⣿⠇⠀⠀⠀⢸⣷⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⠀⠀⠀⠀⢿⣷⣶⣶⣶⣶⣶⣶⣶⣿⠀⠀⠀⠀"
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(18, 28+i);
                Console.WriteLine(art[i]);
            }
        }

        //광대 엔딩
        public void PrintClown()
        {
            string[] art = new string[]
            {
                "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣰⣶⣶⣶⣆⣰⣶⣶⣆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣁⠀⣼⢻⣿⠁⣼⢻⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣹⣿⠀⣿⠘⠛⠀⣿⢸⣿⣇⡀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⣤⣾⠟⠁⣀⡀⠀⠀⣀⡀⠀⢼⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⣠⣶⣶⣄⢹⡷⠀⠀⢿⠇⠰⠆⢿⡇⠀⠀⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀",
    "⠀⠀⠀⢰⣿⣿⣿⣿⡟⣂⡀⠉⠀⠀⠀⠀⠀⠀⠉⣀⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠙⠛⠛⣫⣼⡟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⠋⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠛⣷⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⣶⣶⣿⠛⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⣶⣟⣋⣀⣀⣀⣀⣀⣀⣀⡀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠻⠿⠿⠿⣿⣿⣿⣿⣿⣿⣷⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣶⣶⣿⣻⣿⣿⣿⣿⣿⣷⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⣶⣿⠋⠀⢸⣿⣿⣿⣿⠟⠋⠛⣿⣶⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣶⣿⢻⡄⠀⠀⠙⠁⠀⠀⠀⠀⠀⠛⣿⣶⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣷⡀⠀⣴⣶⣶⣶⣄⣀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠟⠁⠀⠙⣿⣿⣿⣿⣿⣷⣀⣿⣿⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠉⣿⣿⡀⠀⠀⠀⠙⢿⣿⣿⣿⣇⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠉⠿⣷⣤⣄⠀⠀⠀⣙⣷⣶⣿⠿⠉⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠿⠿⠿⠿⠿⠿⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(26, 15+i);
                Console.WriteLine(art[i]);
            }
        }

        //마스코트 엔딩
        public void PrintMascot()
        {
            string[] art = new string[]
                {
"⣿⣿⣿⣿⣿⣿⣿⠿⠿⠉⠉⠉⠉⠉⠉⠉⠿⠷⣿⣿⣿⣿⠾⠿⠉⠉⠉⠉⠉⠉⠉⠿⠷⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⡿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠿⠿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠿⣿⣿⣿⣿",
"⣿⣿⣿⣻⡟⠃⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⢀⣤⣤⣄⢀⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿",
"⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⢰⣿⠉⡉⢹⡏⠉⠉⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿",
"⣿⣿⣿⣿⡇⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⢸⣿⠀⡇⠸⠇⢸⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿",
"⣿⣿⣿⣿⡇⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⢰⣿⠁⠀⠀⠀⠀⠀⠀⠈⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿",
"⣿⣿⣿⣿⣷⡆⠀⠀⠀⠀ ⠀⠀⠀⢰⣿⠁⠀⢸⡷⠀⠀⢸⡇⠀⠈⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿",
"⣿⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀ ⠀⠀⠸⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣷⣤⠀⠀⠀⠀⠀⠀⢸⣿⠠⣦⣠⡄⢠⣄⣠⡄⣿⡇⠀⠀⠀⠀⠀⠀⣤⣾⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⠀⠀⠀⠀⢸⣿⠀⠈⠛⠃⠘⠛⠃⠀⣿⡇⠀⠀⠀⠀⣤⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⠀⠀⠸⣿⡀⠀⣀⣀⣀⣀⡀⢀⣿⠇⠀⠀⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠈⠻⣾⡿⠛⠛⢿⣷⠟⠁⠀⢠⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⢠⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ ",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ ",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⣀⣾⣯⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿",
"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿"
                };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 20+i);
                Console.WriteLine(art[i]);
            }
        }

        //책사 엔딩
        public void PrintAdvisor()
        {
            string[] art = new string[]
            {
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⡆⠀⢰⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⠟⠉⠉⠉⢻⣿⣿⣿⡟⠉⢙⣿⣿⣇⣿⣿⣿⣿⣿⣿⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣅⡀⠀⣾⡏⠉⣿⣿⡇⢰⡇⠉⢹⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⣿⡿⠟⠀⠛⠃⠀⠻⠿⠃⠘⠛⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⢿⣿⣾⣾⣿⣿⣷⣶⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⡿⠋⠀⠀⠀⠀⢰⣾⡆⠀⠀⠀⢀⣶ ⠟⣿⣿⣿⠿⠿⠟⣾⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠰⢾⣿ ⠀⣿⣿⣿⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣿⣿⣿⠀⠀⠀⢿⣿⣿⣤⣄⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣷⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⢿⣿⣿⣿⣷⣶⡆⠀⠈⠁⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠁⢸⣿⣿⣿⣿⣿⡇⠀⠀⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣟⣻⣿⣿⡇⣀⣀⣀⣿⣿⣿⣀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢹⣿⣿⡇⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣼⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⣿⣯⣭⠉⠉⣿⣿⣿⣭⣭⣥⣼⣿⣿⡇⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣷⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣾⣿⣿⠀⠀⠀⠘⢿⣿⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀",
    "⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠻⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠃⠀⠀⠀⠀⠀⠹⠿⢿⣿⠋⠀⠀⠀⠀⠀⠀",
    "⠀⢸⣿⣿⣄⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣿⣿⣷⠀⠀⠀⠀⠀⠀",
    "⠀⠈⠙⣿⣿⣿⣿⣧⣤⣤⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⣤⣤⣼⣿⣿⣿⣿⠋⠁⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠈⠉⠉⢿⣿⣿⣿⣿⣿⣷⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⡿⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
            };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(20, 17+i);
                Console.WriteLine(art[i]);
            }
        }

        //독재자 엔딩
        public void PrintDictator()
        {
            string[] art = new string[]
                {
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣴⣿⣿⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⡏⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣾⣿⣿⣿⣿⡏⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⡇⠀⠀",
    "⠀⠀⠀⠀⠀⣴⣿⣿⣿⣿⣦⠀⠀⣠⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀",
    "⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠀⠀⠀⠀⠀",
    "⠀⠀⠀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣤⡀⠀⠀⠀",
    "⠀⠀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀",
    "⠀⢀⣴⣿⣿⣿⡿⠛⠛⣿⠟⠛⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀",
    "⠀⢸⣿⣿⣿⣿⡇⢰⠀⢿⠀⡆⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀",
    "⢸⣿⣿⣿⣿⣿⢁⣈⡀⠀⠀⣁⡈⢻⣿⣿⣿⣿⣿⣿⣿⠿⠉⠀⠀⠀⠀",
    "⢸⣿⣿⣿⣿⠉⠈⢹⡷⢄⠾⣿⠁⠈⣿⣿⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀",
    "⠀⠸⣿⣿⣿⠀⠀⠀⣠⣤⣤⠀⠀⠀⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠸⣿⣿⠋⡀⠀⠀⠀⠀⠀⢀⡘⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠺⢿⣾⠇⠀⠀⠀⠀⠀⠸⢷⡿⠿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠘⠿⠶⠶⠶⠶⠶⠶⠿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
                };
            string[] art2 = new string[]
            {
    "⠀⠀⢀⣀⣀⡶⠶⠋⠉⠉⠙⠶⠶⠶⠶⣦⡀⠀",
    "⢀⣴⠟⣉⣉⠁⠀⠀⣶⣄⠀⠀⠀⠀⠀⠈⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⢸⣿⢀⣥⡀⠀⠀⠶⠿⣉⠀⠀⠀⠀⠀⠀⠻⣧⣤⣴⠿⠿⠿⢷⣤⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⢈⣽⠟⣉⣁⠀⠀⠺⣿⣤⠀⠀⠀⠀⢠⡼⠿⠿⠋⠉⢀⣄⠀⠈⠉⠉⠉⠉⠿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠘⢿⣤⣤⣤⣤⣤⣤⣿⣭⣤⣴⣧⣼⡏⠑⠒⠒⠀⠀⣼⣿⠇⠀⠀⠀⠀⠀⠀⣿⠀⠀⢠⣤⣤⣤⡄⠀⠀⠀",
    "⠀⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠹⣧⡾⠛⠂⠀⠀⣬⣥⠂⠀⠀⠀⠀⠀⣤⣬⣿⠟⠋⠉⠉⠉⠛⠛⠛⠛⢻⣤",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡏⠐⠒⠒⠀⠀⢸⣿⠃⠀⣠⡄⣤⠟⢁⣀⡄⠀⠀⢸⣧⡄⠀⠀⠀⠀⠀⢸⣿⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⣿⡃⣤⣤⠀⠀⠘⠛⢫⠀⠀⠀⠀⠀⠀⠘⢻⣄⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠟⠡⠤⠄⠀⠘⢻⣷⡄⠀⠀⠀⠀⠀⢸⣿⡋⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⣶⣶⣶⣶⣶⣶⣾⣷⣶⣶⣿⣶⣿⣶⣶⣾⡿⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀"
            };
            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(7, 17+i);
                Console.WriteLine(art[i]);
            }

            for (int i = 0; i < art2.Length; i++)
            {
                Console.SetCursorPosition(35, 25+i);
                Console.WriteLine(art2[i]);
            }
        }

        //학자 엔딩
        public void PrintSchola()
        {
            string[] art = new string[]
            {
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢸⡟⢉⢹⣿⢉⡉⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⢀⢀⣸⡧⢸⠈⠛⠸⠇⣿⣇⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠿⠀⣠⡀⠀⢠⡄⠘⢿⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠄⠛⠃⠃⠘⠣⠄⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣶⠀⠶⣦⠀⠀⣠⣠⣾⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡿⠀⠛⠛⠀⠀⠛⠻⣿⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣶⣶⣶⣶⣶⣶⣶⣶⣾⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⡿⠿⠿⠿⠿⠿⠿⢿⣤⡄⠀⣤⣤⡿⠿⠿⠿⠿⠿⠿⣷⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣾⣿⢩⣶⠤⡦⢠⣶⠤⣶⣾⡍⢻⣿⠋⢽⣶⡦⢠⣶⣦⢠⣶⣾⢽⣿⣶⣀⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠰⠶⠒⠶⠶⠆⠶⠶⠰⠆⢸⣿⠀⠶⠶⠶⠰⠶⠒⠶⠰⠶⢺⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⢘⡛⣓⣛⢛⣛⣓⢛⣛⡃⢸⣿⠀⣛⣓⢛⡛⣃⣛⣛⢃⣛⢻⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⠈⠁⠉⠉⠈⠉⠉⠈⠉⠁⢸⣿⠀⠉⠉⠈⠉⠉⠉⠋⠈⠛⢹⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀",
    "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⣿⣿⣿⣿⡿⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠀⠀⠀⠀⠀⠀⠀" };

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(20, 19+i);
                Console.WriteLine(art[i]);
            }
        }

        //위인 엔딩
        public void PrintGreat()
        {
            string[] art = new string[]
           {"⠀⠀⢀⣀⣀⣀⢀⣀⣀⣀⠀⠀⠀⠀    ⠀⠀⠀⢀⣀⣀⣀⠀⢀⣀⣀⠀⠀⠀⠀⠀        ⠀⠀⣀⣀⣀⡀⣀⣀⣀⡀⠀⠀⠀⠀",
            "⠀⢰⣾⠛⠛⢻⣾⠛⠛⢻⣶⠀⠀⠀    ⠀⠀⢰⣾⠛⠛⢻⣶⣾⠛⢻⣶⣀⠀⠀        ⠀⠀⣶⡟⠛⠛⣷⡟⠛⠛⣷⡆⠀⠀⠀",
            "⠀⢸⣿⢸⡇⠘⠟⢸⡇⢸⣿⠀⠀⠀    ⠀⠀⠸⢿⣤⢸⡏⢸⣿⢸⡏⢸⣿⠀⠀        ⠀⠀⣿⡇⣿⠀⠻⠃⣿⠀⣿⡇⠀⠀⠀",
            "⠀⢸⣿⠀⠀⠀⠀⠀⠀⠘⢿⣦⠀⠀    ⠀⢠⣾⠟⠘⠃⠀⠁⠘⠃⠘⢿⣦⠀         ⠀⣴⡿⠃⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀",
            "⢸⣿⠁⠀⢸⣷⢀⡄⢸⣷⠈⢹⣿   ⠀⠀⢠⣼⠟⠀⠀⢸⣷⠀⢀⣸⣷⠸⢿⣤        ⢸⡏⠀⣿⡆⣠⠀⣿⡆⠀⠉⣿⡇⠀⠀",
            "⢸⣿⠀⠀⠈⢁⣤⣥⣌⢩⣤⣼⣿⠀   ⢠⣼⣿⣄⠀⠀⠈⠁⠀⠀⠉⠉⢠⣼⣿        ⢸⣧⣤⡉⣠⣬⣤⡉⠁⠀⠀⣿⡇⠀⠀",
            "⣿⠻⡶⠀⠀⠈⢛⣻⡿⠈⢛⣻⣿   ⠀ ⢸⣿⣛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿        ⣟⠛⠁⢿⣟⡛⠁⠀⠀⢶⠟⡇⠀⠀",
            "⣿⠀⠀⠀⢀⣀⡈⠋⠀⢰⣾⠛⠀    ⣰⣶⣾⣿⠀⠀⠀⠀⢀⡀⠀⠀⠀⢀⣰⣾⠃        ⠛⣷⡄⠀⠙⣁⣀⠀⠀⠀⠀⡇⠀⠀",
            "⣿⣀⣀⣀⣘⣛⣻⣦⣀⣘⣻⣶    ⣿⣀⣸⣿⣀⣀⣀⣀⣘⣻⣦⣀⣀⣘⣻          ⣷⠀⣶⣟⣁⣀⣶⣟⣛⣁⣀⣀⡇⠀⠀",
            "⠹⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠀    ⠹⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿        ⠀⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠇⠀⠀"};

            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(16, 26+i);
                Console.WriteLine(art[i]);
            }
        }

        //사회운동가 엔딩
        public void PrintActivist()
        {
            string[] art = new string[]
            {
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣴⣶⣶⣿⣿⣿⣿⣿⣷⣶⣶⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣰⣿⡿⠿⠋⠉⠉⠀⠀⠀⠈⠉⠉⠻⠿⣿⣷⣀⠀⠀⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣾⡿⠏⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠿⣿⣷⣄⠀⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⡏⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣿⣿⣄⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⠀⠀⠀⠀⠀⣤⠛⠛⠛⢳⡼⠛⠛⠛⢧⡀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠐⣿⣿⠃⠀⠀⠀⠀⠀⣿⠀⢰⡆⢸⡇⠀⣶⠀⣿⡇⠀⠀⠀⠈⢻⣿⣷⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⣀⡿⠀⠸⠇⠈⠃⠀⠿⠀⠿⣇⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠐⢿⣿⡆⠀⠀⠀⢀⡿⠀⠀⠀⠀⠀⠀⢀⣀⣀⡀⠿⣇⠀⠀⠀⣸⣿⠟⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣧⡀⠀⠀⣿⡇⠀⠶⣶⣶⠆⠐⢾⣿⡏⠀⠀⣿⠀⠀⣸⣿⣿⠀⠀⠀⠀",
            "⠀⠀⠀⠀⠀⠀⣤⣤⣼⣿⣿⣧⡄⠀⣿⡇⠀⠀⠛⠛⠀⠂⠘⠛⠃⠀⠀⣿⠀⣤⣿⣿⠁⠀⠀⠀⠀",
            "⢀⣠⣤⣿⣿⣿⣿⣿⠿⠿⢿⣿⣧⣤⡟⠀⠀⠀⠀⠐⠛⠛⠃⠀⠀⣾⣧⣿⣿⠟⠁⠀⠀⠀⠀⠀",
            "⢸⣿⣿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠙⢿⣿⣿⣦⣤⣤⠀⠀⠀⢠⣤⣤⣾⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀",
            "⠘⢻⣿⡟⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀"
            };


            for (int i = 0; i < art.Length; i++)
            {
                Console.SetCursorPosition(23, 21+i);
                Console.WriteLine(art[i]);
            }
        }
    }
}




   
