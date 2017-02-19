




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
#pragma warning disable 219 //The variable 'lower_limit' is assigned but its value is never used
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Test changefeeds on a table

    [TestFixture]
    public class ChangefeedsTable : YamlTestFixture {

        public ChangefeedsTable (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest_ChangefeedsTable(){

             
             //JavaDef, changefeeds/table.yaml, #9
             //Original: all = tbl.changes()
             
                 var all = maybeRun( (Changes) (tbl.changes()) , conn, new {
                  } );
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIxNSIsIk9yaWdpbmFsIjoidGJsLmluc2VydChbeydpZCc6MX0sIHsnaWQnOjJ9XSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJ0YmwuaW5zZXJ0KHIuYXJyYXkoci5oYXNoTWFwKFwiaWRcIiwgMUwpLCByLmhhc2hNYXAoXCJpZFwiLCAyTCkpKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJwYXJ0aWFsKHsnZXJyb3JzJzowLCAnaW5zZXJ0ZWQnOjJ9KSIsIkV4cGVjdGVkVHlwZSI6IlBhcnRpYWwiLCJFeHBlY3RlZEphdmEiOiJwYXJ0aWFsKHIuaGFzaE1hcChcImVycm9yc1wiLCAwTCkud2l0aChcImluc2VydGVkXCIsIDJMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #15
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':2}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 2L));
                 
                 /* Original: tbl.insert([{'id':1}, {'id':2}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 1L), r.hashMap("id", 2L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIxNyIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsLCAyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6ImZldGNoKGFsbCwgMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImJhZyhbeydvbGRfdmFsJzpudWxsLCAnbmV3X3ZhbCc6eydpZCc6MX19LCB7J29sZF92YWwnOm51bGwsICduZXdfdmFsJzp7J2lkJzoyfX1dKSIsIkV4cGVjdGVkVHlwZSI6IkJhZyIsIkV4cGVjdGVkSmF2YSI6ImJhZyhyLmFycmF5KHIuaGFzaE1hcChcIm9sZF92YWxcIiwgbnVsbCkud2l0aChcIm5ld192YWxcIiwgci5oYXNoTWFwKFwiaWRcIiwgMUwpKSwgci5oYXNoTWFwKFwib2xkX3ZhbFwiLCBudWxsKS53aXRoKFwibmV3X3ZhbFwiLCByLmhhc2hNYXAoXCJpZFwiLCAyTCkpKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #17
                 /* ExpectedOriginal: bag([{'old_val':null, 'new_val':{'id':1}}, {'old_val':null, 'new_val':{'id':2}}]) */
                 var expected_ = bag(r.array(r.hashMap("old_val", null).with("new_val", r.hashMap("id", 1L)), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 2L))));
                 
                 /* Original: fetch(all, 2) */
                 var obtained = runOrCatch( fetch(all, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIyMiIsIk9yaWdpbmFsIjoidGJsLmdldCgxKS51cGRhdGUoeyd2ZXJzaW9uJzoxfSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJ0YmwuZ2V0KDFMKS51cGRhdGUoci5oYXNoTWFwKFwidmVyc2lvblwiLCAxTCkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InBhcnRpYWwoeydlcnJvcnMnOjAsICdyZXBsYWNlZCc6MX0pIiwiRXhwZWN0ZWRUeXBlIjoiUGFydGlhbCIsIkV4cGVjdGVkSmF2YSI6InBhcnRpYWwoci5oYXNoTWFwKFwiZXJyb3JzXCIsIDBMKS53aXRoKFwicmVwbGFjZWRcIiwgMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #22
                 /* ExpectedOriginal: partial({'errors':0, 'replaced':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("replaced", 1L));
                 
                 /* Original: tbl.get(1).update({'version':1}) */
                 var obtained = runOrCatch( tbl.get(1L).update(r.hashMap("version", 1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIyNCIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsLCAxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6ImZldGNoKGFsbCwgMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ilt7J29sZF92YWwnOnsnaWQnOjF9LCAnbmV3X3ZhbCc6eydpZCc6MSwgJ3ZlcnNpb24nOjF9fV0iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheShyLmhhc2hNYXAoXCJvbGRfdmFsXCIsIHIuaGFzaE1hcChcImlkXCIsIDFMKSkud2l0aChcIm5ld192YWxcIiwgci5oYXNoTWFwKFwiaWRcIiwgMUwpLndpdGgoXCJ2ZXJzaW9uXCIsIDFMKSkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #24
                 /* ExpectedOriginal: [{'old_val':{'id':1}, 'new_val':{'id':1, 'version':1}}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L)).with("new_val", r.hashMap("id", 1L).with("version", 1L)));
                 
                 /* Original: fetch(all, 1) */
                 var obtained = runOrCatch( fetch(all, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIyOSIsIk9yaWdpbmFsIjoidGJsLmdldCgxKS5kZWxldGUoKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InRibC5nZXQoMUwpLmRlbGV0ZSgpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InBhcnRpYWwoeydlcnJvcnMnOjAsICdkZWxldGVkJzoxfSkiLCJFeHBlY3RlZFR5cGUiOiJQYXJ0aWFsIiwiRXhwZWN0ZWRKYXZhIjoicGFydGlhbChyLmhhc2hNYXAoXCJlcnJvcnNcIiwgMEwpLndpdGgoXCJkZWxldGVkXCIsIDFMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #29
                 /* ExpectedOriginal: partial({'errors':0, 'deleted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("deleted", 1L));
                 
                 /* Original: tbl.get(1).delete() */
                 var obtained = runOrCatch( tbl.get(1L).delete() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIzMSIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsLCAxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6ImZldGNoKGFsbCwgMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ilt7J29sZF92YWwnOnsnaWQnOjEsICd2ZXJzaW9uJzoxfSwgJ25ld192YWwnOm51bGx9XSIsIkV4cGVjdGVkVHlwZSI6Ikxpc3QiLCJFeHBlY3RlZEphdmEiOiJyLmFycmF5KHIuaGFzaE1hcChcIm9sZF92YWxcIiwgci5oYXNoTWFwKFwiaWRcIiwgMUwpLndpdGgoXCJ2ZXJzaW9uXCIsIDFMKSkud2l0aChcIm5ld192YWxcIiwgbnVsbCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #31
                 /* ExpectedOriginal: [{'old_val':{'id':1, 'version':1}, 'new_val':null}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L).with("version", 1L)).with("new_val", null));
                 
                 /* Original: fetch(all, 1) */
                 var obtained = runOrCatch( fetch(all, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/table.yaml, #36
             //Original: pluck = tbl.changes().pluck({'new_val':['version']})
             
                 var pluck = maybeRun( (Pluck) (tbl.changes().pluck(r.hashMap("new_val", r.array("version")))) , conn, new {
                  } );
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIzNyIsIk9yaWdpbmFsIjoidGJsLmluc2VydChbeydpZCc6NSwgJ3ZlcnNpb24nOjV9XSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJ0YmwuaW5zZXJ0KHIuYXJyYXkoci5oYXNoTWFwKFwiaWRcIiwgNUwpLndpdGgoXCJ2ZXJzaW9uXCIsIDVMKSkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InBhcnRpYWwoeydlcnJvcnMnOjAsICdpbnNlcnRlZCc6MX0pIiwiRXhwZWN0ZWRUeXBlIjoiUGFydGlhbCIsIkV4cGVjdGVkSmF2YSI6InBhcnRpYWwoci5oYXNoTWFwKFwiZXJyb3JzXCIsIDBMKS53aXRoKFwiaW5zZXJ0ZWRcIiwgMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #37
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 1L));
                 
                 /* Original: tbl.insert([{'id':5, 'version':5}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 5L).with("version", 5L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIzOSIsIk9yaWdpbmFsIjoiZmV0Y2gocGx1Y2ssIDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoiZmV0Y2gocGx1Y2ssIDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJbeyduZXdfdmFsJzp7J3ZlcnNpb24nOjV9fV0iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheShyLmhhc2hNYXAoXCJuZXdfdmFsXCIsIHIuaGFzaE1hcChcInZlcnNpb25cIiwgNUwpKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #39
                 /* ExpectedOriginal: [{'new_val':{'version':5}}] */
                 var expected_ = r.array(r.hashMap("new_val", r.hashMap("version", 5L)));
                 
                 /* Original: fetch(pluck, 1) */
                 var obtained = runOrCatch( fetch(pluck, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI0NCIsIk9yaWdpbmFsIjoidGJsLmNoYW5nZXMoKS5vcmRlcl9ieSgnaWQnKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InRibC5jaGFuZ2VzKCkub3JkZXJCeShcImlkXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsIFwiQ2Fubm90IGNhbGwgYSB0ZXJtaW5hbCAoYHJlZHVjZWAsIGBjb3VudGAsIGV0Yy4pIG9uIGFuIGluZmluaXRlIHN0cmVhbSAoc3VjaCBhcyBhIGNoYW5nZWZlZWQpLlwiKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgY2FsbCBhIHRlcm1pbmFsIChgcmVkdWNlYCwgYGNvdW50YCwgZXRjLikgb24gYW4gaW5maW5pdGUgc3RyZWFtIChzdWNoIGFzIGEgY2hhbmdlZmVlZCkuXCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #44
                 /* ExpectedOriginal: err('ReqlQueryLogicError', "Cannot call a terminal (`reduce`, `count`, etc.) on an infinite stream (such as a changefeed).") */
                 var expected_ = err("ReqlQueryLogicError", "Cannot call a terminal (`reduce`, `count`, etc.) on an infinite stream (such as a changefeed).");
                 
                 /* Original: tbl.changes().order_by('id') */
                 var obtained = runOrCatch( tbl.changes().orderBy("id") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/table.yaml, #59
             //Original: overflow = tbl.changes()
             
                 var overflow = maybeRun( (Changes) (tbl.changes()) , conn, new {
                    changefeed_queue_size = 100L ,
                  } );
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI2NCIsIk9yaWdpbmFsIjoidGJsLmluc2VydChyLnJhbmdlKDIwMCkubWFwKGxhbWJkYSB4OiB7fSkpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoidGJsLmluc2VydChyLnJhbmdlKDIwMEwpLm1hcCh4ID0+IHIuaGFzaE1hcCgpKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiQW55dGhpbmdJc0ZpbmUiLCJFeHBlY3RlZFR5cGUiOiJPYmplY3QiLCJFeHBlY3RlZEphdmEiOiJBbnl0aGluZ0lzRmluZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #64
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: tbl.insert(r.range(200).map(lambda x: {})) */
                 var obtained = runOrCatch( tbl.insert(r.range(200L).map(x => r.hashMap())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI2NiIsIk9yaWdpbmFsIjoiZmV0Y2gob3ZlcmZsb3csIDkwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6ImZldGNoKG92ZXJmbG93LCA5MEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InBhcnRpYWwoW3snZXJyb3InOiByZWdleCgnQ2hhbmdlZmVlZCBjYWNoZSBvdmVyIGFycmF5IHNpemUgbGltaXQsIHNraXBwZWQgXFxkKyBlbGVtZW50cy4nKX1dKSIsIkV4cGVjdGVkVHlwZSI6IlBhcnRpYWwiLCJFeHBlY3RlZEphdmEiOiJwYXJ0aWFsKHIuYXJyYXkoci5oYXNoTWFwKFwiZXJyb3JcIiwgcmVnZXgoXCJDaGFuZ2VmZWVkIGNhY2hlIG92ZXIgYXJyYXkgc2l6ZSBsaW1pdCwgc2tpcHBlZCBcXFxcZCsgZWxlbWVudHMuXCIpKSkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #66
                 /* ExpectedOriginal: partial([{'error': regex('Changefeed cache over array size limit, skipped \d+ elements.')}]) */
                 var expected_ = partial(r.array(r.hashMap("error", regex("Changefeed cache over array size limit, skipped \\d+ elements."))));
                 
                 /* Original: fetch(overflow, 90) */
                 var obtained = runOrCatch( fetch(overflow, 90L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/table.yaml, #71
             //Original: vtbl = r.db('rethinkdb').table('_debug_scratch')
             
                 var vtbl = (Table) (r.db("rethinkdb").table("_debug_scratch"));
             
             
             //JavaDef, changefeeds/table.yaml, #72
             //Original: allVirtual = vtbl.changes()
             
                 var allVirtual = maybeRun( (Changes) (vtbl.changes()) , conn, new {
                  } );
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI3NiIsIk9yaWdpbmFsIjoidnRibC5pbnNlcnQoW3snaWQnOjF9LCB7J2lkJzoyfV0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoidnRibC5pbnNlcnQoci5hcnJheShyLmhhc2hNYXAoXCJpZFwiLCAxTCksIHIuaGFzaE1hcChcImlkXCIsIDJMKSkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InBhcnRpYWwoeydlcnJvcnMnOjAsICdpbnNlcnRlZCc6Mn0pIiwiRXhwZWN0ZWRUeXBlIjoiUGFydGlhbCIsIkV4cGVjdGVkSmF2YSI6InBhcnRpYWwoci5oYXNoTWFwKFwiZXJyb3JzXCIsIDBMKS53aXRoKFwiaW5zZXJ0ZWRcIiwgMkwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #76
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':2}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 2L));
                 
                 /* Original: vtbl.insert([{'id':1}, {'id':2}]) */
                 var obtained = runOrCatch( vtbl.insert(r.array(r.hashMap("id", 1L), r.hashMap("id", 2L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI3OCIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsVmlydHVhbCwgMikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJmZXRjaChhbGxWaXJ0dWFsLCAyTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiYmFnKFt7J29sZF92YWwnOm51bGwsICduZXdfdmFsJzp7J2lkJzoxfX0sIHsnb2xkX3ZhbCc6bnVsbCwgJ25ld192YWwnOnsnaWQnOjJ9fV0pIiwiRXhwZWN0ZWRUeXBlIjoiQmFnIiwiRXhwZWN0ZWRKYXZhIjoiYmFnKHIuYXJyYXkoci5oYXNoTWFwKFwib2xkX3ZhbFwiLCBudWxsKS53aXRoKFwibmV3X3ZhbFwiLCByLmhhc2hNYXAoXCJpZFwiLCAxTCkpLCByLmhhc2hNYXAoXCJvbGRfdmFsXCIsIG51bGwpLndpdGgoXCJuZXdfdmFsXCIsIHIuaGFzaE1hcChcImlkXCIsIDJMKSkpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #78
                 /* ExpectedOriginal: bag([{'old_val':null, 'new_val':{'id':1}}, {'old_val':null, 'new_val':{'id':2}}]) */
                 var expected_ = bag(r.array(r.hashMap("old_val", null).with("new_val", r.hashMap("id", 1L)), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 2L))));
                 
                 /* Original: fetch(allVirtual, 2) */
                 var obtained = runOrCatch( fetch(allVirtual, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI4MyIsIk9yaWdpbmFsIjoidnRibC5nZXQoMSkudXBkYXRlKHsndmVyc2lvbic6MX0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoidnRibC5nZXQoMUwpLnVwZGF0ZShyLmhhc2hNYXAoXCJ2ZXJzaW9uXCIsIDFMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoicGFydGlhbCh7J2Vycm9ycyc6MCwgJ3JlcGxhY2VkJzoxfSkiLCJFeHBlY3RlZFR5cGUiOiJQYXJ0aWFsIiwiRXhwZWN0ZWRKYXZhIjoicGFydGlhbChyLmhhc2hNYXAoXCJlcnJvcnNcIiwgMEwpLndpdGgoXCJyZXBsYWNlZFwiLCAxTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #83
                 /* ExpectedOriginal: partial({'errors':0, 'replaced':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("replaced", 1L));
                 
                 /* Original: vtbl.get(1).update({'version':1}) */
                 var obtained = runOrCatch( vtbl.get(1L).update(r.hashMap("version", 1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI4NSIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsVmlydHVhbCwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJmZXRjaChhbGxWaXJ0dWFsLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiW3snb2xkX3ZhbCc6eydpZCc6MX0sICduZXdfdmFsJzp7J2lkJzoxLCAndmVyc2lvbic6MX19XSIsIkV4cGVjdGVkVHlwZSI6Ikxpc3QiLCJFeHBlY3RlZEphdmEiOiJyLmFycmF5KHIuaGFzaE1hcChcIm9sZF92YWxcIiwgci5oYXNoTWFwKFwiaWRcIiwgMUwpKS53aXRoKFwibmV3X3ZhbFwiLCByLmhhc2hNYXAoXCJpZFwiLCAxTCkud2l0aChcInZlcnNpb25cIiwgMUwpKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #85
                 /* ExpectedOriginal: [{'old_val':{'id':1}, 'new_val':{'id':1, 'version':1}}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L)).with("new_val", r.hashMap("id", 1L).with("version", 1L)));
                 
                 /* Original: fetch(allVirtual, 1) */
                 var obtained = runOrCatch( fetch(allVirtual, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI5MCIsIk9yaWdpbmFsIjoidnRibC5nZXQoMSkuZGVsZXRlKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJ2dGJsLmdldCgxTCkuZGVsZXRlKCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoicGFydGlhbCh7J2Vycm9ycyc6MCwgJ2RlbGV0ZWQnOjF9KSIsIkV4cGVjdGVkVHlwZSI6IlBhcnRpYWwiLCJFeHBlY3RlZEphdmEiOiJwYXJ0aWFsKHIuaGFzaE1hcChcImVycm9yc1wiLCAwTCkud2l0aChcImRlbGV0ZWRcIiwgMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, changefeeds/table.yaml, #90
                 /* ExpectedOriginal: partial({'errors':0, 'deleted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("deleted", 1L));
                 
                 /* Original: vtbl.get(1).delete() */
                 var obtained = runOrCatch( vtbl.get(1L).delete() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI5MiIsIk9yaWdpbmFsIjoiZmV0Y2goYWxsVmlydHVhbCwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJmZXRjaChhbGxWaXJ0dWFsLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiW3snb2xkX3ZhbCc6eydpZCc6MSwgJ3ZlcnNpb24nOjF9LCAnbmV3X3ZhbCc6bnVsbH1dIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoci5oYXNoTWFwKFwib2xkX3ZhbFwiLCByLmhhc2hNYXAoXCJpZFwiLCAxTCkud2l0aChcInZlcnNpb25cIiwgMUwpKS53aXRoKFwibmV3X3ZhbFwiLCBudWxsKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #92
                 /* ExpectedOriginal: [{'old_val':{'id':1, 'version':1}, 'new_val':null}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L).with("version", 1L)).with("new_val", null));
                 
                 /* Original: fetch(allVirtual, 1) */
                 var obtained = runOrCatch( fetch(allVirtual, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/table.yaml, #97
             //Original: vpluck = vtbl.changes().pluck({'new_val':['version']})
             
                 var vpluck = maybeRun( (Pluck) (vtbl.changes().pluck(r.hashMap("new_val", r.array("version")))) , conn, new {
                  } );
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiI5OCIsIk9yaWdpbmFsIjoidnRibC5pbnNlcnQoW3snaWQnOjUsICd2ZXJzaW9uJzo1fV0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoidnRibC5pbnNlcnQoci5hcnJheShyLmhhc2hNYXAoXCJpZFwiLCA1TCkud2l0aChcInZlcnNpb25cIiwgNUwpKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoicGFydGlhbCh7J2Vycm9ycyc6MCwgJ2luc2VydGVkJzoxfSkiLCJFeHBlY3RlZFR5cGUiOiJQYXJ0aWFsIiwiRXhwZWN0ZWRKYXZhIjoicGFydGlhbChyLmhhc2hNYXAoXCJlcnJvcnNcIiwgMEwpLndpdGgoXCJpbnNlcnRlZFwiLCAxTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, changefeeds/table.yaml, #98
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 1L));
                 
                 /* Original: vtbl.insert([{'id':5, 'version':5}]) */
                 var obtained = runOrCatch( vtbl.insert(r.array(r.hashMap("id", 5L).with("version", 5L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiY2hhbmdlZmVlZHMvdGFibGUueWFtbCIsIkxpbmVOdW0iOiIxMDAiLCJPcmlnaW5hbCI6ImZldGNoKHZwbHVjaywgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJmZXRjaCh2cGx1Y2ssIDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJbeyduZXdfdmFsJzp7J3ZlcnNpb24nOjV9fV0iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheShyLmhhc2hNYXAoXCJuZXdfdmFsXCIsIHIuaGFzaE1hcChcInZlcnNpb25cIiwgNUwpKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, changefeeds/table.yaml, #100
                 /* ExpectedOriginal: [{'new_val':{'version':5}}] */
                 var expected_ = r.array(r.hashMap("new_val", r.hashMap("version", 5L)));
                 
                 /* Original: fetch(vpluck, 1) */
                 var obtained = runOrCatch( fetch(vpluck, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
