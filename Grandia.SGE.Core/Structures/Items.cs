﻿namespace Grandia.SGE.Core.Structures
{
    public static class Items
    {
        public static string GetInventoryItemName(uint ID)
        {
            try { return ItemList[ID]; }
            catch { return "---"; }
        }

        private static readonly Dictionary<uint, string> ItemList = new() {

          {
            0,
            "---"
          }, {
            10,
            "Spirit Stone"
          }, {
            11,
            "Hero's Armband"
          }, {
            12,
            "Horn of Knowledge"
          }, {
            13,
            "Medal of Wisdom"
          }, {
            14,
            "Medal of Knowledge"
          }, {
            15,
            "Gaia Sprout"
          }, {
            16,
            "Gantz's Key"
          }, {
            17,
            "Intro Letter"
          }, {
            18,
            "Key to the Café"
          }, {
            19,
            "Java's Wallet"
          }, {
            20,
            "Steamer Pass"
          }, {
            21,
            "Lilly's Letter"
          }, {
            22,
            "Cabin Key"
          }, {
            23,
            "Sulfa Weed"
          }, {
            24,
            "Jail Key"
          }, {
            25,
            "Master Key"
          }, {
            26,
            "Nectar of the Gods"
          }, {
            27,
            "Mist-Clearing Nut"
          }, {
            28,
            "Sue's Shoes"
          }, {
            29,
            "Warrior's Spear"
          }, {
            30,
            "Teleportation Orb"
          }, {
            31,
            "Apron"
          }, {
            32,
            "Pot Lid"
          }, {
            33,
            "Iron Pot"
          }, {
            34,
            "Wooden Sword"
          }, {
            35,
            "Spirit Sword"
          }, {
            36,
            "Biscuits"
          }, {
            37,
            "Marie's Pin"
          }, {
            38,
            "Coal Candy"
          }, {
            39,
            "Letter to Clara"
          }, {
            40,
            "Pearl"
          }, {
            41,
            "Rainbow Key"
          }, {
            42,
            "Boiled Egg"
          }, {
            43,
            "Chocolate"
          }, {
            44,
            "Jawbreaker"
          }, {
            45,
            "Ring of Protection"
          }, {
            46,
            "Frost Herb"
          }, {
            47,
            "Amulet of Relief"
          }, {
            48,
            "Prohibited"
          }, {
            49,
            "Prohibited"
          }, {
            50,
            "Prohibited"
          }, {
            51,
            "Prohibited"
          }, {
            52,
            "Prohibited"
          }, {
            53,
            "Prohibited"
          }, {
            54,
            "Prohibited"
          }, {
            55,
            "Prohibited"
          }, {
            56,
            "Prohibited"
          }, {
            57,
            "Prohibited"
          }, {
            58,
            "Prohibited"
          }, {
            59,
            "Prohibited"
          }, {
            60,
            "Prohibited"
          }, {
            61,
            "Prohibited"
          }, {
            62,
            "Prohibited"
          }, {
            63,
            "Knife of Judgment"
          }, {
            64,
            "Rusty Knife"
          }, {
            65,
            "Paring Knife"
          }, {
            66,
            "Hunter's Knife"
          }, {
            67,
            "Flint Knife"
          }, {
            68,
            "Azure Knife"
          }, {
            69,
            "Shocking Knife"
          }, {
            70,
            "Poisoned Knife"
          }, {
            71,
            "Assassin's Dagger"
          }, {
            72,
            "Bloody Knife"
          }, {
            73,
            "Ice Pick"
          }, {
            74,
            "Force Knife"
          }, {
            75,
            "Godspeed Knife"
          }, {
            76,
            "Gust Knife"
          }, {
            77,
            "Ruination Knife"
          }, {
            78,
            "Thief Cutter"
          }, {
            79,
            "Zero Knife"
          }, {
            80,
            "Ceramic Sword"
          }, {
            81,
            "Prohibited"
          }, {
            82,
            "Admiral's Sword"
          }, {
            83,
            "Great Sword"
          }, {
            84,
            "Army Saber"
          }, {
            85,
            "The Sword Himmler"
          }, {
            86,
            "Angel's Darts"
          }, {
            87,
            "Swordfish Sword"
          }, {
            88,
            "Dragon Killer"
          }, {
            89,
            "Fire Sword"
          }, {
            90,
            "Shadow Sword"
          }, {
            91,
            "Gil Sword"
          }, {
            92,
            "Silence Sword"
          }, {
            93,
            "Prohibited"
          }, {
            94,
            "Wobbly Sword"
          }, {
            95,
            "Main Gauche"
          }, {
            96,
            "Holy Sword Lorenzo"
          }, {
            97,
            "Ice Blade"
          }, {
            98,
            "Lightning Sword"
          }, {
            99,
            "Battle Saber"
          }, {
            100,
            "Zero Sword"
          }, {
            101,
            "Wooden Pole"
          }, {
            102,
            "Metal Bat"
          }, {
            103,
            "Zero Rod"
          }, {
            104,
            "Officer's Baton"
          }, {
            105,
            "Magic Rod"
          }, {
            106,
            "Miner's Hammer"
          }, {
            107,
            "Iron Mace"
          }, {
            108,
            "Army Darts"
          }, {
            109,
            "Lassic Hammer"
          }, {
            110,
            "War Hammer"
          }, {
            111,
            "Hertz Spike"
          }, {
            112,
            "Oracle's Staff"
          }, {
            113,
            "Raincloud Staff"
          }, {
            114,
            "Staff of Life"
          }, {
            115,
            "Warp Staff"
          }, {
            116,
            "Holy Mace"
          }, {
            117,
            "Fire Rod"
          }, {
            118,
            "Aromatic Tree Root"
          }, {
            119,
            "Sparkling Rod"
          }, {
            120,
            "Spirit Staff"
          }, {
            121,
            "Home Run Hammer"
          }, {
            122,
            "Rusty Shovel"
          }, {
            123,
            "Hand Ax"
          }, {
            124,
            "Ceremonial Rock Ax"
          }, {
            125,
            "Big Hatchet"
          }, {
            126,
            "Woodchopper's Ax"
          }, {
            127,
            "Dragon Bone Ax"
          }, {
            128,
            "Klepp's Sickle"
          }, {
            129,
            "Frog Ax"
          }, {
            130,
            "Bone Splitter Ax"
          }, {
            131,
            "Earthen Ax"
          }, {
            132,
            "Buster Ax"
          }, {
            133,
            "Wrecking Ax"
          }, {
            134,
            "Bent Mattock"
          }, {
            135,
            "Zero Ax"
          }, {
            136,
            "Toy Bow and Arrow"
          }, {
            137,
            "Handmade Darts"
          }, {
            138,
            "Hunter's Bow"
          }, {
            139,
            "Flying Fish Bow"
          }, {
            140,
            "Hail Bow"
          }, {
            141,
            "Flint Bow"
          }, {
            142,
            "Exorcising Bow"
          }, {
            143,
            "Cafu Shuriken"
          }, {
            144,
            "Boomerang"
          }, {
            145,
            "Fire Darts"
          }, {
            146,
            "Evil Shuriken"
          }, {
            147,
            "Demonslayer Boomer"
          }, {
            148,
            "Discus"
          }, {
            149,
            "Cactus Thorns"
          }, {
            150,
            "Ice Boomerang"
          }, {
            151,
            "Thunder Arrow"
          }, {
            152,
            "Zero Shuriken"
          }, {
            153,
            "Zero Whip"
          }, {
            154,
            "Mist-Cracking Whip"
          }, {
            155,
            "Leather Whip"
          }, {
            156,
            "Thorny Whip"
          }, {
            157,
            "Catfish Whiskers"
          }, {
            158,
            "Giant Snake Whip"
          }, {
            159,
            "Binding Whip"
          }, {
            160,
            "Morning Star"
          }, {
            161,
            "Whip of Light"
          }, {
            162,
            "Burning Hot Whip"
          }, {
            163,
            "Gale Whip"
          }, {
            164,
            "Adventure Clothes"
          }, {
            165,
            "Sunday Best"
          }, {
            166,
            "Sports Wear"
          }, {
            167,
            "Work Clothes"
          }, {
            168,
            "Cactus Armor"
          }, {
            169,
            "Soldier's Uniform"
          }, {
            170,
            "Officer's Uniform"
          }, {
            171,
            "Fairy Robe"
          }, {
            172,
            "Flying Dragon Vest"
          }, {
            173,
            "Frog Shirt"
          }, {
            174,
            "Spy Clothes"
          }, {
            175,
            "Chain Mail"
          }, {
            176,
            "Battle Bikini"
          }, {
            177,
            "Mogay Clothes"
          }, {
            178,
            "Mink Coat"
          }, {
            179,
            "Enchantress' Robe"
          }, {
            180,
            "Angel's Robe"
          }, {
            181,
            "Robe of the Sun"
          }, {
            182,
            "Breastplate"
          }, {
            183,
            "Outdated Armor"
          }, {
            184,
            "Bamboo Armor"
          }, {
            185,
            "Shell Armor"
          }, {
            186,
            "Thick Armor"
          }, {
            187,
            "Swordfish Armor"
          }, {
            188,
            "Skull Armor"
          }, {
            189,
            "Chameleon Armor"
          }, {
            190,
            "Plug Suit"
          }, {
            191,
            "Aura Armor"
          }, {
            192,
            "Dark Armor"
          }, {
            193,
            "Warrior's Mail"
          }, {
            194,
            "Spirit Armor"
          }, {
            195,
            "Devil's Robe"
          }, {
            196,
            "Magic Robe"
          }, {
            197,
            "Cutting Board"
          }, {
            198,
            "Woolen Mittens"
          }, {
            199,
            "Leather Gloves"
          }, {
            200,
            "Escargot Shield"
          }, {
            201,
            "Oaken Shield"
          }, {
            202,
            "Shell Shield"
          }, {
            203,
            "Seashell Shield"
          }, {
            204,
            "Mushroom Shield"
          }, {
            205,
            "MagicMirror Shield"
          }, {
            206,
            "Alligator Gauntlet"
          }, {
            207,
            "Leaf Shield"
          }, {
            208,
            "Lafa Flower Shield"
          }, {
            209,
            "Power Shield"
          }, {
            210,
            "Moonlight Shield"
          }, {
            211,
            "Gauntlets"
          }, {
            212,
            "Dragon Gauntlet"
          }, {
            213,
            "Heavy Shield"
          }, {
            214,
            "Gauntlets of Light"
          }, {
            215,
            "Spirit Shield"
          }, {
            216,
            "Magic Gloves"
          }, {
            217,
            "Zero Shield"
          }, {
            218,
            "Goggles"
          }, {
            219,
            "Ribbon"
          }, {
            220,
            "Fluffy Ribbon"
          }, {
            221,
            "Barrette"
          }, {
            222,
            "Pirate's Hat"
          }, {
            223,
            "Cowboy Hat"
          }, {
            224,
            "Climbing Hat"
          }, {
            225,
            "Odd Hat"
          }, {
            226,
            "Headgear"
          }, {
            227,
            "Iron Bandana"
          }, {
            228,
            "Feathered Turban"
          }, {
            229,
            "Angel's Hat"
          }, {
            230,
            "Pope's Hat"
          }, {
            231,
            "Safety Helmet"
          }, {
            232,
            "Antler Helmet"
          }, {
            233,
            "Pearl Helmet"
          }, {
            234,
            "Pirate's Helmet"
          }, {
            235,
            "Stone Head"
          }, {
            236,
            "Swallowtail Hat"
          }, {
            237,
            "Mystic Mask"
          }, {
            238,
            "Death Mask"
          }, {
            239,
            "Ogre Helm"
          }, {
            240,
            "Charisma Helm"
          }, {
            241,
            "Spirit Helmet"
          }, {
            242,
            "Holy Crown"
          }, {
            243,
            "Cactus Helm"
          }, {
            244,
            "Fairy Tiara"
          }, {
            245,
            "Man's Headband"
          }, {
            246,
            "Battle Helm"
          }, {
            247,
            "Sneakers"
          }, {
            248,
            "Dress Shoes"
          }, {
            249,
            "Air Sneakers"
          }, {
            250,
            "Shiny Shoes"
          }, {
            251,
            "Rubber Boots"
          }, {
            252,
            "Leather Greaves"
          }, {
            253,
            "Hunter's Boots"
          }, {
            254,
            "Army Boots"
          }, {
            255,
            "Curious Clogs"
          }, {
            256,
            "Dragon Boots"
          }, {
            257,
            "Ninja Sandals"
          }, {
            258,
            "Winged Boots"
          }, {
            259,
            "Beach Sandals"
          }, {
            260,
            "Mach 1 Boots"
          }, {
            261,
            "Heavy Boots"
          }, {
            262,
            "Queen Heels"
          }, {
            263,
            "Iron Clogs"
          }, {
            264,
            "Ogre Boots"
          }, {
            265,
            "Rabbit Shoes"
          }, {
            266,
            "Rainbow High Heels"
          }, {
            267,
            "Wolf Boots"
          }, {
            268,
            "Lion Boots"
          }, {
            269,
            "Battle Boots"
          }, {
            270,
            "Spirit Shoes"
          }, {
            271,
            "Glass Slippers"
          }, {
            272,
            "Warp Shoes"
          }, {
            273,
            "Crampons"
          }, {
            274,
            "Zero Boots"
          }, {
            275,
            "Prohibited"
          }, {
            276,
            "Diana's Amulet"
          }, {
            277,
            "Hero's Badge"
          }, {
            278,
            "Demon Sword Amulet"
          }, {
            279,
            "Officer's Badge"
          }, {
            280,
            "Black Belt"
          }, {
            281,
            "Chain Earrings"
          }, {
            282,
            "Titan's Ring"
          }, {
            283,
            "Fireproof Cape"
          }, {
            284,
            "Fire Charm"
          }, {
            285,
            "Water Charm"
          }, {
            286,
            "Wind Charm"
          }, {
            287,
            "Earth Charm"
          }, {
            288,
            "Counter Ring"
          }, {
            289,
            "Secret Move Ring"
          }, {
            290,
            "Hurricane Belt"
          }, {
            291,
            "Mama's Amulet"
          }, {
            292,
            "Jade Charm"
          }, {
            293,
            "Tree God Amulet"
          }, {
            294,
            "Light God Amulet"
          }, {
            295,
            "Ancestor's Amulet"
          }, {
            296,
            "Raincoat"
          }, {
            297,
            "Iridescent Amulet"
          }, {
            298,
            "Move Unblocker"
          }, {
            299,
            "Medal of Yore"
          }, {
            300,
            "Spirit Charm"
          }, {
            301,
            "Phantom Silk"
          }, {
            302,
            "Lightning Charm"
          }, {
            303,
            "Forest Charm"
          }, {
            304,
            "Explosion Charm"
          }, {
            305,
            "Blizzard Charm"
          }, {
            306,
            "Wind Belt"
          }, {
            307,
            "Confusion Charm"
          }, {
            308,
            "Paralysis Charm"
          }, {
            309,
            "Magic Block Charm"
          }, {
            310,
            "Sudden Death Charm"
          }, {
            311,
            "Poison Charm"
          }, {
            312,
            "Talisman"
          }, {
            313,
            "Sonic Belt"
          }, {
            314,
            "Metal Frog"
          }, {
            315,
            "Revival Stone"
          }, {
            316,
            "Use Prohibited"
          }, {
            317,
            "Scarab"
          }, {
            318,
            "Demon Eye Stone"
          }, {
            319,
            "Jewel of Life"
          }, {
            320,
            "Ankh of Temptation"
          }, {
            321,
            "Anklet"
          }, {
            322,
            "Energy Ring"
          }, {
            323,
            "Disease Charm"
          }, {
            324,
            "Paperweight"
          }, {
            325,
            "Combat Anklet"
          }, {
            326,
            "Chain of Gems"
          }, {
            327,
            "Satisfaction Gem"
          }, {
            328,
            "Soul of Asura"
          }, {
            329,
            "Crescent Jade"
          }, {
            330,
            "Dragon Scales"
          }, {
            331,
            "Spectacles"
          }, {
            332,
            "Rune Ring"
          }, {
            333,
            "Tear Jewel"
          }, {
            334,
            "Spirit Potion"
          }, {
            335,
            "Would Salve"
          }, {
            336,
            "Baobab Fruit"
          }, {
            337,
            "Boiled Coconut"
          }, {
            338,
            "Chocolate Cookies"
          }, {
            339,
            "Honey"
          }, {
            340,
            "Ultra Drink"
          }, {
            341,
            "Weeds"
          }, {
            342,
            "Dried Fish"
          }, {
            343,
            "Bamboo Shoots"
          }, {
            344,
            "Beef Jerky"
          }, {
            345,
            "Box Lunch"
          }, {
            346,
            "Herbs"
          }, {
            347,
            "White Sulfa Weed"
          }, {
            348,
            "Smarna Weed"
          }, {
            349,
            "Cholla Flowers"
          }, {
            350,
            "Bamo Fruit"
          }, {
            351,
            "Squid Guts"
          }, {
            352,
            "Move Mushroom"
          }, {
            353,
            "Power Mushroom"
          }, {
            354,
            "Poison Antidote"
          }, {
            355,
            "Ginseng"
          }, {
            356,
            "Banana"
          }, {
            357,
            "Bandage"
          }, {
            358,
            "Box of Sweets"
          }, {
            359,
            "First Aid Kit"
          }, {
            360,
            "Red Medicine"
          }, {
            361,
            "Blue Medicine"
          }, {
            362,
            "Yellow Medicine"
          }, {
            363,
            "Crimson Potion"
          }, {
            364,
            "Deep Blue Potion"
          }, {
            365,
            "Golden Potion"
          }, {
            366,
            "Magic Lamp"
          }, {
            367,
            "Poison Antidote"
          }, {
            368,
            "Vaccine"
          }, {
            369,
            "Eye Drops"
          }, {
            370,
            "Smelling Salts"
          }, {
            371,
            "Paralysis Ointment"
          }, {
            372,
            "Spell Breaker"
          }, {
            373,
            "Move Breaker"
          }, {
            374,
            "Resurrect Potion"
          }, {
            375,
            "Panacea"
          }, {
            376,
            "Bond of Trust"
          }, {
            377,
            "Seed of Power"
          }, {
            378,
            "Seed of Defense"
          }, {
            379,
            "Seed of Speed"
          }, {
            380,
            "Seed of Running"
          }, {
            381,
            "All-Around Seed"
          }, {
            382,
            "Seed of Life"
          }, {
            383,
            "Seed of Magic"
          }, {
            384,
            "Seed of Moves"
          }, {
            385,
            "Mace Coloring Book"
          }, {
            386,
            "Bow Coloring Book"
          }, {
            387,
            "Sword Secrets"
          }, {
            388,
            "Fire Secrets"
          }, {
            389,
            "Earth Secrets"
          }, {
            390,
            "How to Cut 'Em"
          }, {
            391,
            "How to Pound 'Em"
          }, {
            392,
            "How to Chop 'Em"
          }, {
            393,
            "Roach Bomb"
          }, {
            394,
            "Firewood Sparks"
          }, {
            395,
            "Mana Egg"
          }, {
            396,
            "Holy Fire"
          }, {
            397,
            "Hand Grenade"
          }, {
            398,
            "Dynamite"
          }, {
            399,
            "Rocket Fireworks"
          }, {
            400,
            "Launch Fireworks"
          }, {
            401,
            "BOOM! Scroll"
          }, {
            402,
            "Howler Scroll"
          }, {
            403,
            "Vacuum Scroll"
          }, {
            404,
            "Tremor Scroll"
          }, {
            405,
            "Zap! Book"
          }, {
            406,
            "Lightning Scroll"
          }, {
            407,
            "Gale Scroll"
          }, {
            408,
            "Overflowing Walnut"
          }, {
            409,
            "Restraint Walnut"
          }, {
            410,
            "Sonic Walnut"
          }, {
            411,
            "Running Walnut"
          }, {
            412,
            "Snooze Scroll"
          }, {
            413,
            "Poisoned Apple"
          }, {
            414,
            "Culture Medium"
          }, {
            415,
            "Dream Truffle"
          }, {
            416,
            "Paralyze Mushroom"
          }, {
            417,
            "Orb of Silence"
          }, {
            418,
            "Black Onyx"
          }, {
            419,
            "Weak-Knee Weed"
          }, {
            420,
            "Ragged Weed"
          }, {
            421,
            "Slouch Weed"
          }, {
            422,
            "Trudge Weed"
          }, {
            423,
            "Root of Confusion"
          }, {
            424,
            "Torte's Whistle"
          }, {
            425,
            "Freesia Flowers"
          }, {
            426,
            "Cone of Light"
          }, {
            427,
            "Mikeroma Scroll"
          }, {
            428,
            "Shuffle Card"
          }, {
            429,
            "Miracle Drink"
          }, {
            430,
            "Gold Key"
          }, {
            431,
            "Silver Key"
          }, {
            432,
            "Key of Temptation"
          }, {
            433,
            "Soldier's Key"
          }, {
            434,
            "Pretty Jewel"
          }, {
            435,
            "Pretty Jewel"
          }, {
            436,
            "Pretty Jewel"
          }, {
            437,
            "Horn of Inogon"
          }, {
            438,
            "Key"
          }, {
            439,
            "Health Weed"
          }, {
            440,
            "Snake Earrings"
          }, {
            441,
            "Resurrect Potion"
          }, {
            442,
            "Expensive Jewel"
          }, {
            443,
            "Rainbow Weed"
          }, {
            444,
            "Smoked Salmon"
          }, {
            445,
            "Prime Rib"
          }, {
            446,
            "Rescue Set"
          }, {
            447,
            "Black Nail Polish"
          }, {
            448,
            "Prohibited"
          }, {
            449,
            "Thor's Fury"
          }, {
            450,
            "Magic Lipstick"
          }, {
            451,
            "Elite Badge"
          }, {
            452,
            "Fruit of Power"
          }, {
            453,
            "Fruit of Defense"
          }, {
            454,
            "Fruit of Speed"
          }, {
            455,
            "Fruit of Agility"
          }, {
            456,
            "All-Around Fruit"
          }, {
            457,
            "Fruit of Life"
          }, {
            458,
            "Fruit of Magic"
          }, {
            459,
            "Fruit of Moves"
          }, {
            460,
            "Mogay Teachings 1"
          }, {
            461,
            "Mogay Teachings 2"
          }, {
            462,
            "Mogay Teachings 3"
          }, {
            463,
            "Ring of Rage"
          }, {
            464,
            "Holy Ring"
          }, {
            465,
            "Mysterious Veil"
          }, {
            466,
            "Blizzard Scroll"
          }, {
            467,
            "Telescope"
          }, {
            468,
            "Energy Charm"
          }, {
            469,
            "Devil's Anklet"
          }, {
            470,
            "Prohibited"
          }, {
            471,
            "Astral Miracle"
          }, {
            472,
            "Ethereal Miracle"
          }, {
            473,
            "Miraculous Scales"
          }, {
            474,
            "General's Staff"
          }, {
            475,
            "Brown Crayon"
          }, {
            476,
            "Blue Crayon"
          }, {
            477,
            "Red Crayon"
          }, {
            478,
            "Sky-Blue Crayon"
          }, {
            479,
            "Emperor's Whip"
          }, {
            480,
            "Soldier's Soul"
          }, {
            481,
            "Poison of Power"
          }, {
            482,
            "Poison of Defense"
          }, {
            483,
            "Poison of Speed"
          }, {
            484,
            "Poison of Agility"
          }, {
            485,
            "All-Around Poison"
          }, {
            486,
            "Poison of Life"
          }, {
            487,
            "Poison of Magic"
          }, {
            488,
            "Poison of Moves"
          }, {
            489,
            "+1 Dagger Skill"
          }, {
            490,
            "+5 Dagger Skill"
          }, {
            491,
            "+1 Sword Skill"
          }, {
            492,
            "+5 Sword Skill"
          }, {
            493,
            "+1 Mace Skill"
          }, {
            494,
            "+5 Mace Skill"
          }, {
            495,
            "+1 Ax Skill"
          }, {
            496,
            "+5 Ax Skill"
          }, {
            497,
            "+1 Whip Skill"
          }, {
            498,
            "+5 Whip Skill"
          }, {
            499,
            "+1 Bow Skill"
          }, {
            500,
            "+5 Bow Skill"
          }, {
            501,
            "+1 Fire Skill"
          }, {
            502,
            "+5 Fire Skill"
          }, {
            503,
            "+1 Wind Skill"
          }, {
            504,
            "+5 Wind Skill"
          }, {
            505,
            "+1 Water Skill"
          }, {
            506,
            "+5 Water Skill"
          }, {
            507,
            "+1 Earth Skill"
          }, {
            508,
            "+5 Earth Skill"
          }, {
            509,
            "100 Sword"
          }, {
            510,
            "100 Mace"
          }, {
            511,
            "100 Fire Mace"
          },
        };
    }
}
