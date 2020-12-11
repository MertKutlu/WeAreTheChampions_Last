namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAreTheChampions.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Models.WeAreTheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Models.WeAreTheChampionsContext context)
        {
            //if (!context.Colors.Any())
            //{
            //    context.Colors.AddRange(Color());
            //}
            //if (!context.Teams.Any())
            //    context.Teams.AddRange(Team());
            //if (!context.Players.Any())
            //    context.Players.AddRange(Player());
            //if (!context.Matches.Any())
            //{
            //    context.Matches.Add((new Match() { Team1Id = 1, Team2Id = 2, Score1 = 3, Score2 = 0 }));
            //}
        }
        //private List<Models.Color> Color()
        //{

        //    return new List<Models.Color>()
        //    {
        //        new Models.Color() { ColorName = "Siyah", Red = 0, Blue = 0, Green = 0},
        //        new Models.Color() { ColorName = "Kırmızı", Red = 255, Blue = 0, Green = 0},
        //        new Models.Color() { ColorName = "Mavi", Red = 0, Blue = 255, Green = 0},
        //        new Models.Color() { ColorName = "Yeşil", Red = 0, Blue = 0, Green = 255},
        //        new Models.Color() { ColorName = "Beyaz", Red = 255, Blue = 255, Green = 255},

        //    };
        //}
        //private List<Team> Team()
        //{

        //    return new List<Team>()
        //    {
        //        new Team() { TeamName = "Fenebahçe"},
        //        new Team() { TeamName = "Galatasaray"}

        //    };
        //}
        //private List<Player> Player()
        //{
        //    return new List<Player>()
        //    {
        //        new Player() {  PlayerName ="Altay Bayindir", TeamId = 1 },
        //        new Player() {  PlayerName ="Marcel Tisserand", TeamId = 1 },
        //        new Player() {  PlayerName ="Mauricio Lemos", TeamId = 1 },
        //        new Player() {  PlayerName ="Caner Erkin", TeamId = 1 },
        //        new Player() {  PlayerName ="Gökhan Gönül", TeamId = 1 },
        //        new Player() {  PlayerName ="Luiz Gustavo", TeamId = 1 },
        //        new Player() {  PlayerName ="Ozan Tufan", TeamId = 1 },
        //        new Player() {  PlayerName ="José Sosa", TeamId = 1 },
        //        new Player() {  PlayerName ="Mame Thiam", TeamId = 1 },
        //        new Player() {  PlayerName ="Enner Valencia", TeamId = 1 },
        //        new Player() {  PlayerName ="Papiss Demba Cissé", TeamId = 1 },

        //        new Player() {  PlayerName ="Fernando Muslera", TeamId = 2 },
        //        new Player() {  PlayerName ="Marcão", TeamId = 2 },
        //        new Player() {  PlayerName ="Christian Luyindama", TeamId = 2 },
        //        new Player() {  PlayerName ="Valentine Ozornwafor", TeamId = 2 },
        //        new Player() {  PlayerName ="Emre Tasdemir", TeamId = 2 },
        //        new Player() {  PlayerName ="Martin Linnes", TeamId = 2 },
        //        new Player() {  PlayerName ="Oghenekaro Etebo", TeamId = 2 },
        //        new Player() {  PlayerName ="Younès Belhanda", TeamId = 2 },
        //        new Player() {  PlayerName ="Ryan Babel", TeamId = 2 },
        //        new Player() {  PlayerName ="Arda Turan", TeamId = 2 },
        //        new Player() {  PlayerName ="Falcao", TeamId = 2 }
        //    };
        //}
    }
}
