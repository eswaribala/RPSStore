using RPSStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.Data
{
    public static class CategoryData
    {
        public static IList<Category> Categories;

        static CategoryData()
        {
            Categories = new List<Category>();
            Categories.Add(new Category { CategoryId = "XXdyQgAACAAJ", Name = "The C Book, Featuring the ANSI C Standard", Details = "This book presents an introduction to the C programming language, featuring a structured approach and aimed at professionals and students with some experience of high-level languages. Features *includes embedded summary material in bulleted form *highlights common traps and pitfalls in C programming.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg" });
            Categories.Add(new Category { CategoryId = "r0MxxLI1l_QC", Name = "Loran-C Table", Details = "This book presents an introduction to the C programming language, featuring a structured approach and aimed at professionals and students with some experience of high-level languages. Features *includes embedded summary material in bulleted form *highlights common traps and pitfalls in C programming.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG" });
            Categories.Add(new Category { CategoryId = "BREwDwAAQBAJ", Name = "Effective Java", 
                Details = "This highly anticipated new edition of the classic, Jolt Award-winning work has been thoroughly updated to cover Java SE 5 and Java SE 6 features introduced since the first edition. Bloch explores new design patterns and language idioms, showing you how to make the most of features ranging from generics to enums, annotations to autoboxing.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg/320px-Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg"
            });
            Categories.Add(new Category { CategoryId = "pxGrMwEACAAJ", Name = "Introduction to Programming Using Java", 
                Details = "This is a free, on-line textbook on introductory programming using Java. This book is directed mainly towards beginning programmers, although it might also be useful for experienced programmers who want to learn more about Java", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Grosser_Panda.JPG/320px-Grosser_Panda.JPG"
            });
            Categories.Add(new Category { CategoryId = "Q3_QDwAAQBAJ", Name = "Java Performance", 
                Details = "Coding and testing are generally considered separate areas of expertise. In this practical book, Java expert Scott Oaks takes the approach that anyone who works with Java should be adept at understanding how code behaves in the Java Virtual Machine—including the tunings likely to help performance. This updated second edition helps you gain in-depth knowledge of Java application performance using both the JVM and the Java platform. Developers and performance engineers alike will learn a variety of features, tools, and processes for improving the way the Java 8 and 11 LTS releases perform. While the emphasis is on production-supported releases and features, this book also features previews of exciting new technologies such as ahead-of-time compilation and experimental garbage collections. Understand how various Java platforms and compilers affect performance Learn how Java garbage collection works Apply four principles to obtain best results from performance testing Use the JDK and other tools to learn how a Java application is performing Minimize the garbage collector’s impact through tuning and programming practices Tackle performance issues in Java APIs Improve Java-driven database application performance", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Sloth_Bear_Washington_DC.JPG/320px-Sloth_Bear_Washington_DC.JPG"
            });



        }
    }
}
