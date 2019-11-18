using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMastery.Migrations
{
    public partial class AddedGameSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SeriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "SeriesId", "Name" },
                values: new object[,]
                {
                    { 1, "Halo" },
                    { 2, "BioShock" },
                    { 3, "Kingdom Hearts" },
                    { 4, "Batman: Arkham" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "SeriesId" },
                values: new object[,]
                {
                    { 1, "Halo: Combat Evolved", 1 },
                    { 26, "Kingdom Hearts", 3 },
                    { 27, "Chain of Memories", 3 },
                    { 28, "Kingdom Hearts II", 3 },
                    { 29, "Re:Chain of Memories", 3 },
                    { 30, "KH: Coded", 3 },
                    { 31, "358/2 Days", 3 },
                    { 32, "Birth by Sleep", 3 },
                    { 33, "Re:coded", 3 },
                    { 34, "Dream Drop Distance", 3 },
                    { 35, "1.5 Remix", 3 },
                    { 36, "KH: X", 3 },
                    { 37, "2.5 Remix", 3 },
                    { 38, "Unchained χ", 3 },
                    { 39, "2.8 Final Chapter Prologue", 3 },
                    { 40, "Kingdom Hearts III", 3 },
                    { 41, "Arkham Asylum", 4 },
                    { 42, "Arkham City", 4 },
                    { 43, "Arkham City Lockdown", 4 },
                    { 44, "Arkham Origins", 4 },
                    { 25, "Parkside (TBD)", 2 },
                    { 24, "BioShock: The Collection", 2 },
                    { 23, "BioShock Infinite: Burial at Sea Part II", 2 },
                    { 22, "BioShock Infinite: Burial at Sea Part I", 2 },
                    { 2, "Halo 2", 1 },
                    { 3, "Halo 3", 1 },
                    { 4, "Halo Wars", 1 },
                    { 5, "Halo 3: ODST", 1 },
                    { 6, "Halo: Reach", 1 },
                    { 7, "Halo: Combat Evolved Anniversary", 1 },
                    { 8, "Halo 4", 1 },
                    { 9, "Halo: Spartan Assault", 1 },
                    { 10, "Halo: The Master Chief Collection", 1 },
                    { 45, "Arkham Origins Blackgate", 4 },
                    { 11, "Halo: Spartan Strike", 1 },
                    { 13, "Halo Wars 2", 1 },
                    { 14, "Halo: Fireteam Raven", 1 },
                    { 15, "Halo Infinite", 1 },
                    { 16, "BioShock", 2 },
                    { 17, "BioShock: Challenge Rooms", 2 },
                    { 18, "BioShock 2", 2 },
                    { 19, "BioShock 2: Minerva's Den", 2 },
                    { 20, "BioShock: Industrial Revolution", 2 },
                    { 21, "BioShock Infinite", 2 },
                    { 12, "Halo 5: Guardians", 1 },
                    { 46, "Arkham Knight", 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Body", "GameId", "Title" },
                values: new object[,]
                {
                    { 1, "This immersive sci-fi epic delivers both an expansive story and electrifying first-person combat, making it one of 2001's best games.", 1, "Combat Evolved" },
                    { 67, "Kingdom Hearts 3D is the pinnacle of the Kingdom Hearts portable formula, unifying everything that the series did right in the format and many new, smart ideas.", 34, "Cool Game" },
                    { 66, "Kingdom Hearts: Re:Coded is one of the low points of the franchise's history. The game has some great ideas buried within, but the execution leaves much to be desired.", 33, "Awesome Game" },
                    { 65, "It's a funny sequel, allthough the all times fans should be asking for something more (or new) from the developers. Despite the lack of innovation, Re: Coded is literallly filled with content, and still worth its price if you love the brand.", 33, "Cool Game" },
                    { 64, "With its deeply satisfying series of campaigns, solid battle and progression systems, and a worthwhile multiplayer component, you'd be foolish to pass this one up.", 32, "Awesome Game" },
                    { 63, "Kingdom Hearts: Birth By Sleep is a beautiful Square Enix's RPG, which includes the Disney's magic in the style of Final Fantasy.", 32, "Cool Game" },
                    { 62, "A great continuation to the Kingdom Hearts saga, 358/2 Days offers great customization options, fluid gameplay and awesome visuals, but suffers from recycled material.", 31, "Awesome Game" },
                    { 61, "For all its intricate plot threads, the game is at its best during these little character moments.", 31, "Cool Game" },
                    { 60, "When it comes to action, variety, and the sheer fun of obliterating Heartless with a Keyblade, coded is a more-than-worthwhile entry in the beloved Kingdom Hearts saga. ", 30, "Awesome Game" },
                    { 59, "If you're looking for a game that's filled with breezy fun, excellent graphics, solid characters, and all the worlds of Disney in the palm of your hand with a lot of The Matrix thrown in for good measure, then Kingdom Hearts: Coded should absolutely be in your collection.", 30, "Cool Game" },
                    { 58, "An impressive remake that improves the presentation of the original GBA version by leaps and bounds while simultaneously streamlining the battle system.", 29, "Awesome Game" },
                    { 57, "Kingdom Hearts Re: Chain of Memories for the PS2 is definitely worth checking out, especially if you haven't yet played the GBA original.", 29, "Cool Game" },
                    { 56, "A game well worth playing. It lasts much longer than any game should have to, squeezing out new experiences wherever possible.", 28, "Awesome Game" },
                    { 55, "Kingdom Hearts II, I am relieved to say, delivers on everything the series' potential hinted at.", 28, "Cool Game" },
                    { 54, "An impressive remake that improves the presentation of the original GBA version by leaps and bounds while simultaneously streamlining the battle system.", 27, "Awesome Game" },
                    { 53, "Kingdom Hearts Re: Chain of Memories for the PS2 is definitely worth checking out, especially if you haven't yet played the GBA original.", 27, "Cool Game" },
                    { 52, "I really don’t think anyone else could have woven as complex and enthralling a story into such enjoyable gameplay and kept it as true to both Square and especially Disney fans.", 26, "Awesome Game" },
                    { 51, "You’ll be hard pressed to find another game that even comes close to matching the quality found in Kingdom Hearts. Games just don’t come as beautiful and well thought out as this, it’s a virtual masterpiece that excels in every way possible.", 26, "Cool Game" },
                    { 50, "Looks Promising", 25, "Awesome Game" },
                    { 49, "Can't Wait!!!", 25, "Cool Game" },
                    { 68, "Whether or not you're a fan of Nintendo's latest handheld console, if you love Kingdom Hearts, this is a must-have title that's filled with fantastic gameplay, an intriguing story, and beautiful visuals.", 34, "Awesome Game" },
                    { 48, "The Bioshock Collection is the perfect way to revisit this amazing franchise in glorious FULL HD graphics.", 24, "Awesome Game" },
                    { 69, "There is a certain magic present here that a decade has only made stronger. Newcomers and fans alike will find enjoyment in this collection and you won’t able to help smiling at plenty of moments, even if you’ve seen them play out before.", 35, "Cool Game" },
                    { 71, "Fun to play!!!", 36, "Cool Game" },
                    { 90, "Next to Arkham City, Arkham Origins is a bit of a disappointment in its lack of new ideas and use of win buttons, making it the least interesting of the trilogy.", 45, "Awesome Game" },
                    { 89, "Yes, most of the game seems like a copy of Arkham City, but that doesn't take away the overall high quality that comes from the lush world, the superb fighting system and the great characters WB Montreal created.", 45, "Cool Game" },
                    { 88, "The mobile version of Arkham Origins delivers just enough Bat-action to keep fans happy, but falls short overall due to a restricted fighting system.", 44, "Awesome Game" },
                    { 87, "Simply put, Batman: Arkham Origins is the definitive example of a console tie-in game done right", 44, "Cool Game" },
                    { 86, "This game looks nothing short of gorgeous, and it really shows off how pretty an iOS game can be.", 43, "Awesome Game" },
                    { 85, "The gadgets make for a good change in pace and the boss battles mean Lockdown stands out from being an Infinity Blade clone.", 43, "Cool Game" },
                    { 84, "If there is one game you buy this year, make it Batman: Arkham City. Few other games released this year will reach this level of polish, variety, story quality, action, scale, and length.", 42, "Awesome Game" },
                    { 83, "Arkham City should be celebrated as a shining achievement for the action-adventure genre for its masterful execution", 42, "Cool Game" },
                    { 82, "I can’t recommend Arkam Asylum enough.", 41, "Awesome Game" },
                    { 81, "Yes, this is the Batman you've been waiting for...It's a wonderful experience, beginning to end, never taking the easy or familiar route, and infusing each shift of the story with original ideas that cut no corners. ", 41, "Cool Game" },
                    { 80, "There is no doubt that Kingdom Hearts III will make long term fans moved or even cry. As for those new to the franchise, I believe they also can be satisfied because of tons of classic Disney elements and solid combat system, even though they could barely understand the main story.", 40, "Awesome Game" },
                    { 79, "The developer has refined and perfected the combat. It kept its silliness in tact. It kept in the darker themes and deep moments of self-reflection that we all need every once in awhile. It’s, quite frankly, the best Kingdom Hearts game Square Enix has ever created.", 40, "Cool Game" },
                    { 78, "Kingdom Hearts fans - particularly those who can justify the game's astronomical price point of $60 for about five hours of new content - will definitely enjoy their brief time with Kingdom Hearts HD 2.8 Final Chapter Prologue.", 39, "Awesome Game" },
                    { 77, "While it’s not the new Kingdom Hearts game that many may have wanted, it’s much more than just a simple collection of old titles or some cheap cash-in. It’s a bridge to what awaits, and I can’t help but feel excited after watching the credits roll for the umpteenth time.", 39, "Cool Game" },
                    { 76, "It certainly doesn’t hold a candle to the console games, but it carries itself surprisingly well as a handheld side story.", 38, "Awesome Game" },
                    { 75, "I’ve spent a bit of time with the game since I downloaded it earlier this week, and even though I’m still early on, I’m enjoying every minute of it. Sure, it may not be a main Kingdom Hearts game, but it is definitely something to help satisfy my Kingdom Hearts fix until KH3 comes out.", 38, "Cool Game" },
                    { 74, "A great collection, though the lack of any real gameplay in Kingdom Hearts Re: Coded is a weak point.", 37, "Awesome Game" },
                    { 73, "Kingdom Hearts II Final Mix and Birth by Sleep improved with new combats and extra content: an unmissable collection for every fan to keep up with the saga.", 37, "Cool Game" },
                    { 72, "In my top 5 easy", 36, "Awesome Game" },
                    { 70, "Just like in the first go around, there’s a lot to do in this game.", 35, "Awesome Game" },
                    { 47, "The story telling, unique environments, gameplay and amount of content included makes Bioshock The Collection a must buy.", 24, "Cool Game" },
                    { 46, "Burial At Sea's second episode is lovely to look at and sports some surprisingly enjoyable sneaky combat, but both are used to tell a story that, without flowcharts and some seriously generous apologetics, is convoluted to migraine-inducing degrees.", 23, "Awesome Game" },
                    { 45, "Burial at Sea Episode Two too often feels like well-made fan fiction", 23, "Cool Game" },
                    { 20, "Halo: The Master Chief Collection really sets the standard for all future re-release game collections.", 10, "Awesome Game" },
                    { 19, "There's more love and care lavished on The Master Chief Collection than you see in countless other big-money, brand new blockbuster releases. The fact that the games themselves are fantastic fun online and off is the cherry on the icing.", 10, "Cool Game" },
                    { 18, "Much like Halo Wars before it, this game fills in some of the gaps in the Halo story while experimenting with a new gameplay style. While Halo Wars was a RTS, this is a twin-stick shooter, and a darn good one at that. It feels like a steal for just $9.99", 9, "Awesome Game" },
                    { 17, "Halo: Spartan Assault brings the Halo universe once again back on the Xbox 360, but in a different way as you are used to see the franchise. This top-down shooter is an enjoyable journey through the world of the Spartans. However, it is a very short adventure. Too short in our opinion.", 9, "Cool Game" },
                    { 16, "This is THE best Halo game yet, and although the campaign in short, there's an abundance of content to keep Halo 4 in your disc tray.", 8, "Awesome Game" },
                    { 15, "If you're a Halo fan, you've probably already pre-ordered and purchased this game and thankfully the game more than lived up to its hype. Even if you have never played a Halo game before, it's still one of the best first person shooters on any console.", 8, "Cool Game" },
                    { 14, "Halo: Combat Evolved Anniversary is more than just a simple high defintion remake. The game is running on two engines, the original CE one and a new one. It's a great way to show the progress that has been made in ten years. In spite of some technical errors and the absence of many original multiplayer maps, 343 shows that it has the power to create next year's Halo 4.", 7, "Awesome Game" },
                    { 13, "They could have easily just threw on a fresh coat of paint on it and called it an HD remake like a lot of other titles, but 343 has more respect for Bungie, Halo and the fans than that. They have added a ton of new features well worth the $40 price tag.", 7, "Cool Game" },
                    { 12, "ODST could have been a clever little shimmy, but it came out a misstep. Reach brings us right back into the dance that hooked us nine years ago, introduces some cool new steps, and leaves us twirling in enchantment as Bungie graciously bows out. Just keep twirling, Spartan.", 6, "Awesome Game" },
                    { 11, "Halo: Reach is without doubt Bungie's finest Halo game, and best of all it has the story and structure to the campaign to finally deliver the Halo experience that some of us have been waiting for since the original Halo: Combat Evolved launched on Xbox back in 2002.", 6, "Cool Game" },
                    { 10, "Whether you're looking to go it alone, check out Halo 3's full suite of multiplayer options, or just see how long you and your buddies can keep the Grim Reaper at bay in Firefight, ODST has something for everyone.", 5, "Awesome Game" },
                    { 9, "Halo expands focusing on the smallest things, with new gameplay and the same excellence we are used to.", 5, "Cool Game" },
                    { 8, "This is a fun game..LIGHT RTS but fun in action. I wonder if it would have gotten better critic scores had it not been part of the Halo Franchise? More Multiplayer Options would have bumped my score. Bottom line is that the game is fun.", 4, "Awesome Game" },
                    { 7, "Purists and veterans will probably dismiss Halo Wars due to its lack of depth, but Halo fans and the uninitiated should jump right in. It's probably the strongest RTS game that's ever been released for a console, and as an entry point into the genre, it's pretty much unbeatable.", 4, "Cool Game" },
                    { 6, "In substance it's nothing new, merely a magnificent, beautiful monster of an FPS sequel. In concept and execution, though, Halo 3 is the future", 3, "Awesome Game" },
                    { 5, "It's solid gameplay, immense replayability, online functionality and incredible production values will ensure its place in video game history, and it is, without a doubt, a satisfying and fulfilling close to the beloved trilogy.", 3, "Cool Game" },
                    { 4, "A fantastic example of pure artistic vision coupled with serious technological know-how.", 2, "Awesome Game" },
                    { 3, "Probably my favorite war shooter multiplayer game. Had so much fun with this one. One of the best multiplayers ever.", 2, "Awesome Game" },
                    { 2, "The original Halo is definitely something to play on Xbox! Learn how the franchise began and see the coolest hero in gaming history: Spartan 117-The Master Chief! Yes, Halo Combat Evolved is a true original.", 1, "Awesome Game" },
                    { 21, "A gorgeous, surprisingly deep shooter that sucks you back into Halo's universe. Fun and flashy in all the right ways.", 11, "Cool Game" },
                    { 22, "Halo: Spartan Strike combines the look and feel of a classic Halo game with the mechanics of a solid dual stick shooter.", 11, "Awesome Game" },
                    { 23, "Developers from 343 Industries have finally caught the right way and with the fifth part they fixed the mistakes which they made in the previous installment. So they provide the players with an absolutely perfect and catchy campaign", 12, "Cool Game" },
                    { 24, "Although the story feels less of an event, Halo 4's campaign is a thoroughly satisfying spectacle. ", 12, "Awesome Game" },
                    { 44, "STEALTH IS A SURPRISINGLY ENJOYABLE COUNTERPOINT TO THE LARGE-SCALE MASSACRES OF INFINITE", 22, "Awesome Game" },
                    { 43, "BURIAL AT SEA TIES THE INFINITE WORLD OF BIOSHOCK TOGETHER IN INTERESTING WAYS", 22, "Cool Game" },
                    { 42, "With the release of BioShock Infinite, developer Irrational has delivered a bigger story, more polished experience, and created two similar-yet-separate games that can co-exist and remain equal in quality. When the history of videogames is written, not one, but two BioShocks will be remembered for pushing gameplay, story, and subject matter to new levels.", 21, "Awesome Game" },
                    { 41, "Great music. Great Game. Great story. Great plot. Great DLC. Great atmosphere. Great connection to the first Bioshock.", 21, "Cool Game" },
                    { 40, "It's a masterpiece in story telling You have to play it to experience it", 20, "Awesome Game" },
                    { 39, "I had an amazing time with this game. I absolutely loved the game despite not playing any other game in the bio shock series", 20, "Cool Game" },
                    { 38, "Some refreshing of the game's major mechanics or pacing could have spliced this DLC to the next level, but unfortunately its repetitive nature holds it back. If you are a sucker for Rapture lore, then Minerva's Den may yet be worth the $10.", 19, "Awesome Game" },
                    { 37, "A satisfying self-contained chapter, driven by an engrossing story, with exploration encouraged. Plus flying laser robots.", 19, "Cool Game" },
                    { 36, "Maybe Bioshock 2 is not as emotionally engaging as its first iteration, but at same time retains the main virtues of its predecessor. A game that shows the maturity that the First Person Shooter has achieved in this generation.", 18, "Awesome Game" },
                    { 91, "A great release for those who enjoy the Arkham games but haven't played Blackgate for whatever reason.", 46, "Cool Game" },
                    { 35, "The weapons are better. The plasmids are better. The enemies are better. At some points, even the storytelling is better. What’s most amazing and surprising about BioShock 2, however, is that by diving deeper into Rapture’s tortured history and exploring more of Rapture’s haunted world, it actually manages to make the original BioShock better, too.", 18, "Cool Game" },
                    { 33, "The Challenge rooms are quite enjoyable, but are almost over too quickly.", 17, "Cool Game" },
                    { 32, "The first-person shooter is, simply, one of the best games ever made. ", 16, "Awesome Game" },
                    { 31, "BioShock is on the same par as those great classic films that have won awards for years and this one will for the video game industry. The combination of a great story and fantastic gameplay with wonderful scenery has been so well created into an all around well crafted game that it would be a shame to miss out on playing it.", 16, "Cool Game" },
                    { 30, "Looks Promising", 15, "Awesome Game" },
                    { 29, "Can't Wait!!!", 15, "Cool Game" },
                    { 28, "A quality game to play with friends!", 14, "Awesome Game" },
                    { 27, "This game is crazy fun! Played it at an arcade with friends and we had a blast. Every time we saw Iron chef we would all scream CHIEF SIR, I recommend this game for anyone who wants to have fun with friends.", 14, "Cool Game" },
                    { 26, "Halo Wars 2 is still a highly recommendable title — in fact, likely one of the best RTS games that can be found on the current generation. However, accessibility on consoles came with a price to both controls and gameplay in both campaign and multiplayer modes.", 13, "Awesome Game" },
                    { 25, "At the end of the day, however, it’s the multiplayer and gameplay that make or break an RTS game, and Halo Wars 2 checks those boxes. If you’ve ever had the itch to command an army of UNSC soldiers, Halo Wars 2 will easily scratch it.", 13, "Cool Game" },
                    { 34, "Fun to play", 17, "Awesome Game" },
                    { 92, "It feels quite far from the main episodes, but if you looking for a metroidvania game, with good exploring sections and puzzles, this is an interesting choice.", 46, "Awesome Game" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId",
                table: "Comments",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SeriesId",
                table: "Games",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
