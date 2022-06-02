﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_server.Model {
    internal class Game {
        public string id { get; set; }
        public Player player1 { get; set; }
        public Player player2 { get; set; }

        public Game(string id, Player p1, Player p2) {
            this.id = id;
            this.player1 = p1;
            this.player2 = p2;
        }
    }
}
