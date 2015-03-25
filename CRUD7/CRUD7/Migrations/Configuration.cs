using CRUD7.Models;

namespace CRUD7.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Data.Entity.Validation;
    using System.Diagnostics;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD7.Models.CRUD7Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUD7.Models.CRUD7Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.images.AddOrUpdate(x => x.Id,
                new images() { Id = 1, imageUrl = "css/img/sapiens.jpg" },
                new images() { Id = 2, imageUrl = "css/img/natten.jpg" },
                new images() { Id = 3, imageUrl = "css/img/rings.jpg" },
                new images() { Id = 4, imageUrl = "css/img/towers.jpg" },
                new images() { Id = 5, imageUrl = "css/img/king.jpg" },
                new images() { Id = 6, imageUrl = "css/img/silmarillion.jpg" },
                new images() { Id = 7, imageUrl = "css/img/shining.jpg" },
                new images() { Id = 8, imageUrl = "css/img/bird.jpg" },
                new images() { Id = 9, imageUrl = "css/img/martian.jpg" },
                new images() { Id = 10, imageUrl = "css/img/storm.jpg" },
                new images() { Id = 11, imageUrl = "css/img/rand.jpg" },
                new images() { Id = 12, imageUrl = "css/img/stalker.jpg" }
                );

            context.ratings.AddOrUpdate(x => x.Id,
                new rating() { Id = 1, rate = 1},
                new rating() { Id = 2, rate = 1.5},
                new rating() { Id = 3, rate = 2},
                new rating() { Id = 4, rate = 2.5},
                new rating() { Id = 5, rate = 3},
                new rating() { Id = 6, rate = 3.5},
                new rating() { Id = 7, rate = 4},
                new rating() { Id = 8, rate = 4.5},
                new rating() { Id = 9, rate = 5}       
                );
                
            context.authors.AddOrUpdate(x => x.Id,
                new authors() { Id = 1, name = "Yuval Noah Harari" },
                new authors() { Id = 2, name = "Dean Koontz" },
                new authors() { Id = 3, name = "J.R.R Tolkien" },
                new authors() { Id = 4, name = "Stephen King" },
                new authors() { Id = 5, name = "Harper Lee" },
                new authors() { Id = 6, name = "Andy Weir" },
                new authors() { Id = 7, name = "Robert Jordan" },
                new authors() { Id = 8, name = "Ken Follett" },
                new authors() { Id = 9, name = "Lars Kepler" }
        );
            context.genres.AddOrUpdate(x => x.Id,
                new genres() { Id = 1, genre = "Historia & arkeologi", description = "Historia är våra berättelser om det förflutna. Historia är också namnet på vetenskapen där forskare undersöker och försöker förstå och beskriva det som hände förr."},
                new genres() { Id = 2, genre = "Deckare", description = "Deckare är i vid mening den skönlitterära genre som sorteras under spänningslitteratur och som handlar om brott, hur de klaras upp, olika brottslingar och deras motiv. " },
                new genres() { Id = 3, genre = "Fantasy", description = "Fantasy är en kulturell genre där en avvikande verklighet, till exempel magi eller andra övernaturliga företeelser, spelar en viktig roll. Delar som tillhör fantasyberättelsens grund är först och främst fantasivärlden, vilken kan vara likt en sagovärld, eller likna västvärldens medeltid." },
                new genres() { Id = 4, genre = "Skräck", description = "Skräckgenren skildrar oftast en människas, eller en grupp människors, rädsla för något livsfarligt - antingen något naturligt som en galen mördare, eller något övernaturligt som en vampyr eller varulv." },
                new genres() { Id = 5, genre = "Fiktion", description = "Fiktion (av latin fingere, skapa, göra), innebär något påhittat eller uppdiktat, fantasi, till skillnad från det verkliga." },
                new genres() { Id = 6, genre = "Science-fiction", description = "Science fiction är en genre inom litteratur och film där bärande element i intrig eller miljö har inslag grundade på vetenskapliga eller teknologiska spekulationer." },
                new genres() { Id = 7, genre = "Historisk skönlitteratur", description = "Historisk skönlitteratur är påhittade äventyr eller händelser som utspelar sig under en viss tidsepok." }          
       );
            context.books.AddOrUpdate(x => x.Id,
                new books()
                {
                    Id = 1,
                    title = "Sapiens : en kort historik över mänskligheten",
                    description = "För cirka 70 000 år sedan var jorden befolkad av minst sex olika mänskliga arter. Ingen av dem hade någon större inverkan på den globala ekologin. Idag har bara en art överlevt - Homo sapiens. Hur blev det så? En del av hemligheten bakom framgångarna är att vi är det enda djur som kan prata om saker som existerar enbart i vår egen fantasi, såsom gudar, nationer, pengar och mänskliga rättigheter. Om detta och mycket mer handlar denna internationella bästsäljare som ger nytt bränsle åt diskussionen om vårt gemensamma förflutna och planetens framtid",
                    year = 2015,
                    isbn = "9789127140394",
                    stock = 24,
                    ratingId = 1,
                    imagesId = 1,
                    genresId = 1,
                    authorsId = 1,
                },
                new books()
                {
                    Id = 2,
                    title = "Vad natten döljer",
                    description = "En gång för länge sedan anlände en mördare till en liten stad. Hans namn var Alton Turner Blackwood, och inom loppet av några månader hade han brutalt mördat fyra familjer. Hans vansinnesdåd slutade inte förrän han själv dödades av den sista familjens sista överlevande: en fjortonårig pojke. En halv kontinent bort och två decennier senare är det någon som mördar familjer igen och i detalj återskapar Blackwoods dåd. Mordutredaren John Calvino är säker på att hans egen familj kommer att bli måltavlan för det fjärde dådet, precis som hans föräldrar och systrar blev offer den där gången när han var fjorton år och dödade deras mördare. Calvino är en förnuftig man som i sitt arbete som mordutredare bara handskas med kalla fakta. Men en upplevelse utöver det vanliga övertygar honom om att döden inte alltid behöver vara en enkelriktad resa ibland kan de döda komma tillbaka ...",
                    year = 2012,
                    isbn = "9789170029684",
                    stock = 20,
                    ratingId = 2,
                    imagesId = 2,
                    genresId = 2,
                    authorsId = 2,
                },
                new books()
                {
                    Id = 3,
                    title = "Lord Of The Rings",
                    description = "This is the first book of Tolkien's trilogy The Lord of the Rings. Sauron, the Dark Lord, has gathered the Rings of Power so that he can rule Middle-earth. All he lacks in his plans for domination is one Ring - the Ring that has fallen into the hands of the hobbit, Bilbo Baggins.",
                    year = 1991,
                    isbn = "9780261102354",
                    stock = 15,
                    ratingId = 3,
                    imagesId = 3,
                    genresId = 3,
                    authorsId = 3,
                },
                new books()
                {
                    Id = 4,
                    title = "Lord Of The Rings: The two towers",
                    description = "Frodo and the Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord. They have lost the wizard, Gandalf, and must now continue their journey alone down the River Anduin.",
                    year = 1991,
                    isbn = "9780261102361",
                    stock = 25,
                    ratingId = 4,
                    imagesId = 4,
                    genresId = 3,
                    authorsId = 3,
                },
                new books()
                {
                    Id = 5,
                    title = "The Lord of the Rings: Return of the King",
                    description = "Features stories of the separate adventures of the Companions of the Ring. The adventures include Aragorn, revealed as the heir of the Kings of the West, who joined with the Riders of Rohan against the forces of Isengard, and Merry and Pippin who were captured by Orcs but escape into the forest.",
                    year = 1991,
                    isbn = "9780261102378",
                    stock = 26,
                    ratingId = 5,
                    imagesId = 5,
                    genresId = 3,
                    authorsId = 3,
                },
                new books()
                {
                    Id = 6,
                    title = "The Silmarillion",
                    description = "A new B-format edition of this novel, designed to take fans of The Hobbit and The Lord of the Rings deeper into the myths and legends of Middle-earth The Silmarillion is an account of the Elder Days, of the First Age of Tolkien's world. It is the ancient drama to which the characters in The Lord of the Rings look back, and in whose events some of them such as Elrond and Galadriel took part. The tales of The Silmarillion are set in an age when Morgoth, the first Dark Lord, dwelt in Middle-Earth, and the High Elves made war upon him for the recovery of the Silmarils, the jewels containing the pure light of Valinor. Included in the book are several shorter works. The Ainulindale is a myth of the Creation and in the Valaquenta the nature and powers of each of the gods is described. The Akallabeth recounts the downfall of the great island kingdom of Numenor at the end of the Second Age and Of the Rings of Power tells of the great events at the end of the Third Age, as narrated in The Lord of the Rings. This pivotal work features the revised, corrected text and includes, by way of an introduction, a fascinating letter written by Tolkien in 1951 in which he gives a full explanation of how he conceived the early Ages of Middle-earth.",
                    year = 2013,
                    isbn = "9780007523221",
                    stock = 27,
                    ratingId = 6,
                    imagesId = 6,
                    genresId = 3,
                    authorsId = 3,
                },
                new books()
                {
                    Id = 7,
                    title = "The Shining",
                    description = "Danny is only five years old, but in the words of old Mr Hallorann he is a 'shiner', aglow with psychic voltage. When his father becomes caretaker of the Overlook Hotel, Danny's visions grow out of control. As winter closes in and blizzards cut them off, the hotel seems to develop a life of its own. It is meant to be empty. So who is the lady in Room 217 and who are the masked guests going up and down in the elevator? And why do the hedges shaped like animals seem so alive? Somewhere, somehow, there is an evil force in the hotel - and that, too, is beginning to shine ...",
                    year = 2011,
                    isbn = "9781444720723",
                    stock = 28,
                    ratingId = 7,
                    imagesId = 7,
                    genresId = 4,
                    authorsId = 4,
                },
                new books()
                {
                    Id = 8,
                    title = "To Kill a Mockingbird",
                    description = "This has been voted the book adults should read before they die. The survey of librarians to mark World Book Day 2006 came out in favour of The Bible in second place and The Lord of the Rings trilogy in third place. The timeless classic of growing up and the human dignity that unites us all. The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill a Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer prize in 1961 and was later made into an Academy Award winning film, also a classic. Compassion, dramatic, and deeply moving, To Kill a Mockingbird takes readers to the roots of human behavior to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 15 million copies in print and translated into ten languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature.",
                    year = 1988,
                    isbn = "9780446310789",
                    stock = 29,
                    ratingId = 8,
                    imagesId = 8,
                    genresId = 5,
                    authorsId = 5,
                },
                new books()
                {
                    Id = 9,
                    title = "The Martian",
                    description = "The Sunday Times bestseller - Robinson Crusoe on Mars, a survival story for the 21st Century. I'm stranded on Mars. I have no way to communicate with Earth. I'm in a Habitat designed to last 31 days. If the Oxygenator breaks down, I'll suffocate. If the Water Reclaimer breaks down, I'll die of thirst. If the Hab breaches, I'll just kind of explode. If none of those things happen, I'll eventually run out of food and starve to death. So yeah. I'm screwed. The Martian is featured in Richard & Judy's Autumn Book Club 2014.",
                    year = 2014,
                    isbn = "9780091956141",
                    stock = 30,
                    ratingId = 9,
                    imagesId = 9,
                    genresId = 6,
                    authorsId = 6,
                },
                new books()
                {
                    Id = 10,
                    title = "The Gathering Storm",
                    description = "The Gathering Storm is the first of three books that will complete the struggle against the Shadow, bringing to a close a journey begun almost 20 years ago and marking the conclusion of The Wheel of Time, created by Jordan and completed by Sanderson.",
                    year = 2010,
                    isbn = "9780765341532",
                    stock = 31,
                    ratingId = 1,
                    imagesId = 10,
                    genresId = 3,
                    authorsId = 7,
                },
                new books()
                {
                    Id = 11,
                    title = "Evighetens rand",
                    description = "Den östtyska läraren Rebecca Hoffman upptäcker att Stasi spionerar på henne och fattar ett hastigt beslut som kommer att påverka hennes familj för resten av livet. Juristen George Jakes blir rekryterad till Robert Kennedys justitiedepartement och befinner sig plötsligt mitt i kampen för medborgerliga rättigheter, samtidigt som han måste utkämpa en annan strid på det mer personliga planet. Cameron Dewar, sonson till en senator, går med på att bli spion för att tjäna de högre syften han tror på, men tvingas inse att världen är en farligare plats än han kunnat ana. Och Dimka Dvorkin, en av Nikita Chrusjtjovs unga medarbetare, dras in i det kalla kriget mellan Sovjetunionen och USA, medan hans syster Tania tar sig från Moskva till Kuba, Prag och Warszawa - och rakt in i historien.",
                    year = 2015,
                    isbn = "9789100146351",
                    stock = 32,
                    ratingId = 2,
                    imagesId = 11,
                    genresId = 7,
                    authorsId = 8,
                },
                new books()
                {
                    Id = 12,
                    title = "Stalker",
                    description = "För nio år sedan dömdes prästen Rocky Kyrklund till rättspsykiatrisk vård för ett brutalt mord. Själv minns han ingenting. Efter en svår olycka har han återkommande blackouter. Samma sommar som hans återanpassning till samhället påbörjas, skickar någon en filmsekvens på en kvinna i ett fönster till polisen. Nästa dag hittas kvinnan död i sitt hem. Det är inte bara det bestialiska våldet som leder tankarna till Rocky Kyrklunds gamla mord. En ny film kommer till polisen. Ingen förstår vad som händer och Joona Linna är försvunnen sedan mer än ett år. Nästan alla tror att han är död. Nästan alla.",
                    year = 2014,
                    isbn = "9789100136741",
                    stock = 33,
                    ratingId = 3,
                    imagesId = 12,
                    genresId = 2,
                    authorsId = 9,
                }
                );
        }
    }
}
