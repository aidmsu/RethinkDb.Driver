




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class DatumUuid : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/uuid.yaml, #1
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: r.uuid()
                 var obtained = runOrCatch( r.uuid() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/uuid.yaml, #2
                 //ExpectedOriginal: None
                 var expected = null as object;
                 
                 //Original: r.expr(r.uuid())
                 var obtained = runOrCatch( r.expr(r.uuid()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/uuid.yaml, #3
                 //ExpectedOriginal: ('STRING')
                 var expected = "STRING";
                 
                 //Original: r.type_of(r.uuid())
                 var obtained = runOrCatch( r.typeOf(r.uuid()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/uuid.yaml, #4
                 //ExpectedOriginal: (true)
                 var expected = true;
                 
                 //Original: r.uuid().ne(r.uuid())
                 var obtained = runOrCatch( r.uuid().ne(r.uuid()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/uuid.yaml, #5
                 //ExpectedOriginal: (10)
                 var expected = 10.0;
                 
                 //Original: r.expr([1,2,3,4,5,6,7,8,9,10]).map(lambda u:r.uuid()).distinct().count()
                 var obtained = runOrCatch( r.expr(r.array(1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0)).map(u => r.uuid()).distinct().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}