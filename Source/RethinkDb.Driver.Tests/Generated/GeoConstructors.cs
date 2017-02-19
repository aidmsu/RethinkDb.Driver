




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

    // Test geo constructors

    [TestFixture]
    public class GeoConstructors : YamlTestFixture {

        public GeoConstructors (){
        }




        [Test]
        public void YamlTest_GeoConstructors(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjQiLCJPcmlnaW5hbCI6InIucG9pbnQoMCwgMCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvaW50KDBMLCAwTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6WzAsIDBdLCAndHlwZSc6J1BvaW50J30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgMEwpKS53aXRoKFwidHlwZVwiLCBcIlBvaW50XCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/constructors.yaml, #4
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 0], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point");
                 
                 /* Original: r.point(0, 0) */
                 var obtained = runOrCatch( r.point(0L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjYiLCJPcmlnaW5hbCI6InIucG9pbnQoMCwgLTkwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucG9pbnQoMEwsIC05MEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Iih7JyRyZXFsX3R5cGUkJzonR0VPTUVUUlknLCAnY29vcmRpbmF0ZXMnOlswLCAtOTBdLCAndHlwZSc6J1BvaW50J30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgLTkwTCkpLndpdGgoXCJ0eXBlXCIsIFwiUG9pbnRcIikiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #6
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, -90], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, -90L)).with("type", "Point");
                 
                 /* Original: r.point(0, -90) */
                 var obtained = runOrCatch( r.point(0L, -90L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjgiLCJPcmlnaW5hbCI6InIucG9pbnQoMCwgOTApIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2ludCgwTCwgOTBMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIoeyckcmVxbF90eXBlJCc6J0dFT01FVFJZJywgJ2Nvb3JkaW5hdGVzJzpbMCwgOTBdLCAndHlwZSc6J1BvaW50J30pIiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiJHJlcWxfdHlwZSRcIiwgXCJHRU9NRVRSWVwiKS53aXRoKFwiY29vcmRpbmF0ZXNcIiwgci5hcnJheSgwTCwgOTBMKSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #8
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 90], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 90L)).with("type", "Point");
                 
                 /* Original: r.point(0, 90) */
                 var obtained = runOrCatch( r.point(0L, 90L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjEwIiwiT3JpZ2luYWwiOiJyLnBvaW50KC0xODAsIDApIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2ludCgtMTgwTCwgMEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Iih7JyRyZXFsX3R5cGUkJzonR0VPTUVUUlknLCAnY29vcmRpbmF0ZXMnOlstMTgwLCAwXSwgJ3R5cGUnOidQb2ludCd9KSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcIiRyZXFsX3R5cGUkXCIsIFwiR0VPTUVUUllcIikud2l0aChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoLTE4MEwsIDBMKSkud2l0aChcInR5cGVcIiwgXCJQb2ludFwiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #10
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[-180, 0], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(-180L, 0L)).with("type", "Point");
                 
                 /* Original: r.point(-180, 0) */
                 var obtained = runOrCatch( r.point(-180L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjEyIiwiT3JpZ2luYWwiOiJyLnBvaW50KDE4MCwgMCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvaW50KDE4MEwsIDBMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIoeyckcmVxbF90eXBlJCc6J0dFT01FVFJZJywgJ2Nvb3JkaW5hdGVzJzpbMTgwLCAwXSwgJ3R5cGUnOidQb2ludCd9KSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcIiRyZXFsX3R5cGUkXCIsIFwiR0VPTUVUUllcIikud2l0aChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoMTgwTCwgMEwpKS53aXRoKFwidHlwZVwiLCBcIlBvaW50XCIpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/constructors.yaml, #12
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[180, 0], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(180L, 0L)).with("type", "Point");
                 
                 /* Original: r.point(180, 0) */
                 var obtained = runOrCatch( r.point(180L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjE0IiwiT3JpZ2luYWwiOiJyLnBvaW50KDAsIC05MSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvaW50KDBMLCAtOTFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoJ1JlcWxRdWVyeUxvZ2ljRXJyb3InLCAnTGF0aXR1ZGUgbXVzdCBiZSBiZXR3ZWVuIC05MCBhbmQgOTAuICBHb3QgLTkxLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiTGF0aXR1ZGUgbXVzdCBiZSBiZXR3ZWVuIC05MCBhbmQgOTAuICBHb3QgLTkxLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #14
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Latitude must be between -90 and 90.  Got -91.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Latitude must be between -90 and 90.  Got -91.", r.array(0L));
                 
                 /* Original: r.point(0, -91) */
                 var obtained = runOrCatch( r.point(0L, -91L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjE2IiwiT3JpZ2luYWwiOiJyLnBvaW50KDAsIDkxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucG9pbnQoMEwsIDkxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0xhdGl0dWRlIG11c3QgYmUgYmV0d2VlbiAtOTAgYW5kIDkwLiAgR290IDkxLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiTGF0aXR1ZGUgbXVzdCBiZSBiZXR3ZWVuIC05MCBhbmQgOTAuICBHb3QgOTEuXCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #16
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Latitude must be between -90 and 90.  Got 91.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Latitude must be between -90 and 90.  Got 91.", r.array(0L));
                 
                 /* Original: r.point(0, 91) */
                 var obtained = runOrCatch( r.point(0L, 91L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjE4IiwiT3JpZ2luYWwiOiJyLnBvaW50KC0xODEsIDApIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2ludCgtMTgxTCwgMEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdMb25naXR1ZGUgbXVzdCBiZSBiZXR3ZWVuIC0xODAgYW5kIDE4MC4gIEdvdCAtMTgxLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwibG9uZ2l0dWRlIG11c3QgYmUgYmV0d2VlbiAtMTgwIGFuZCAxODAuICBHb3QgLTE4MS5cIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/constructors.yaml, #18
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Longitude must be between -180 and 180.  Got -181.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "longitude must be between -180 and 180.  Got -181.", r.array(0L));
                 
                 /* Original: r.point(-181, 0) */
                 var obtained = runOrCatch( r.point(-181L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjIwIiwiT3JpZ2luYWwiOiJyLnBvaW50KDE4MSwgMCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvaW50KDE4MUwsIDBMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoJ1JlcWxRdWVyeUxvZ2ljRXJyb3InLCAnTG9uZ2l0dWRlIG11c3QgYmUgYmV0d2VlbiAtMTgwIGFuZCAxODAuICBHb3QgMTgxLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwibG9uZ2l0dWRlIG11c3QgYmUgYmV0d2VlbiAtMTgwIGFuZCAxODAuICBHb3QgMTgxLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #20
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Longitude must be between -180 and 180.  Got 181.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "longitude must be between -180 and 180.  Got 181.", r.array(0L));
                 
                 /* Original: r.point(181, 0) */
                 var obtained = runOrCatch( r.point(181L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjI4IiwiT3JpZ2luYWwiOiJyLmxpbmUoWzAsMF0sIFswLDBdKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIubGluZShyLmFycmF5KDBMLCAwTCksIHIuYXJyYXkoMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0ludmFsaWQgTGluZVN0cmluZy4gIEFyZSB0aGVyZSBhbnRpcG9kYWwgb3IgZHVwbGljYXRlIHZlcnRpY2VzPycsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiSW52YWxpZCBMaW5lU3RyaW5nLiAgQXJlIHRoZXJlIGFudGlwb2RhbCBvciBkdXBsaWNhdGUgdmVydGljZXM/XCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #28
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Invalid LineString.  Are there antipodal or duplicate vertices?', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Invalid LineString.  Are there antipodal or duplicate vertices?", r.array(0L));
                 
                 /* Original: r.line([0,0], [0,0]) */
                 var obtained = runOrCatch( r.line(r.array(0L, 0L), r.array(0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjMwIiwiT3JpZ2luYWwiOiJyLmxpbmUoWzAsMF0sIFswLDFdKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIubGluZShyLmFycmF5KDBMLCAwTCksIHIuYXJyYXkoMEwsIDFMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6W1swLDBdLCBbMCwxXV0sICd0eXBlJzonTGluZVN0cmluZyd9KSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcIiRyZXFsX3R5cGUkXCIsIFwiR0VPTUVUUllcIikud2l0aChcImNvb3JkaW5hdGVzXCIsIHIuYXJyYXkoci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAxTCkpKS53aXRoKFwidHlwZVwiLCBcIkxpbmVTdHJpbmdcIikiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #30
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0,0], [0,1]], 'type':'LineString'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L))).with("type", "LineString");
                 
                 /* Original: r.line([0,0], [0,1]) */
                 var obtained = runOrCatch( r.line(r.array(0L, 0L), r.array(0L, 1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjMyIiwiT3JpZ2luYWwiOiJyLmxpbmUoWzAsMF0sIFsxXSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmxpbmUoci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDFMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHBvaW50IGNvb3JkaW5hdGUgcGFpci4gIEdvdCAxIGVsZW1lbnQgYXJyYXkgaW5zdGVhZCBvZiBhIDIgZWxlbWVudCBvbmUuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCBwb2ludCBjb29yZGluYXRlIHBhaXIuICBHb3QgMSBlbGVtZW50IGFycmF5IGluc3RlYWQgb2YgYSAyIGVsZW1lbnQgb25lLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #32
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected point coordinate pair.  Got 1 element array instead of a 2 element one.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected point coordinate pair.  Got 1 element array instead of a 2 element one.", r.array(0L));
                 
                 /* Original: r.line([0,0], [1]) */
                 var obtained = runOrCatch( r.line(r.array(0L, 0L), r.array(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjM0IiwiT3JpZ2luYWwiOiJyLmxpbmUoWzAsMF0sIFsxLDAsMF0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5saW5lKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgxTCwgMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHBvaW50IGNvb3JkaW5hdGUgcGFpci4gIEdvdCAzIGVsZW1lbnQgYXJyYXkgaW5zdGVhZCBvZiBhIDIgZWxlbWVudCBvbmUuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCBwb2ludCBjb29yZGluYXRlIHBhaXIuICBHb3QgMyBlbGVtZW50IGFycmF5IGluc3RlYWQgb2YgYSAyIGVsZW1lbnQgb25lLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #34
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected point coordinate pair.  Got 3 element array instead of a 2 element one.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected point coordinate pair.  Got 3 element array instead of a 2 element one.", r.array(0L));
                 
                 /* Original: r.line([0,0], [1,0,0]) */
                 var obtained = runOrCatch( r.line(r.array(0L, 0L), r.array(1L, 0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjM2IiwiT3JpZ2luYWwiOiJyLmxpbmUoWzAsMF0sIFswLDFdLCBbMCwwXSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmxpbmUoci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAxTCksIHIuYXJyYXkoMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6W1swLDBdLCBbMCwxXSwgWzAsMF1dLCAndHlwZSc6J0xpbmVTdHJpbmcnfSkiLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCIkcmVxbF90eXBlJFwiLCBcIkdFT01FVFJZXCIpLndpdGgoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDBMLCAwTCkpKS53aXRoKFwidHlwZVwiLCBcIkxpbmVTdHJpbmdcIikiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #36
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0,0], [0,1], [0,0]], 'type':'LineString'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(0L, 0L))).with("type", "LineString");
                 
                 /* Original: r.line([0,0], [0,1], [0,0]) */
                 var obtained = runOrCatch( r.line(r.array(0L, 0L), r.array(0L, 1L), r.array(0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjM4IiwiT3JpZ2luYWwiOiJyLmxpbmUoci5wb2ludCgwLDApLCByLnBvaW50KDAsMSksIHIucG9pbnQoMCwwKSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmxpbmUoci5wb2ludCgwTCwgMEwpLCByLnBvaW50KDBMLCAxTCksIHIucG9pbnQoMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6W1swLDBdLCBbMCwxXSwgWzAsMF1dLCAndHlwZSc6J0xpbmVTdHJpbmcnfSkiLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCIkcmVxbF90eXBlJFwiLCBcIkdFT01FVFJZXCIpLndpdGgoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDBMLCAwTCkpKS53aXRoKFwidHlwZVwiLCBcIkxpbmVTdHJpbmdcIikiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #38
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0,0], [0,1], [0,0]], 'type':'LineString'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(0L, 0L))).with("type", "LineString");
                 
                 /* Original: r.line(r.point(0,0), r.point(0,1), r.point(0,0)) */
                 var obtained = runOrCatch( r.line(r.point(0L, 0L), r.point(0L, 1L), r.point(0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjQwIiwiT3JpZ2luYWwiOiJyLmxpbmUoci5wb2ludCgwLDApLCByLnBvaW50KDEsMCksIHIubGluZShbMCwwXSwgWzEsMF0pKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIubGluZShyLnBvaW50KDBMLCAwTCksIHIucG9pbnQoMUwsIDBMKSwgci5saW5lKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgxTCwgMEwpKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIGdlb21ldHJ5IG9mIHR5cGUgYFBvaW50YCBidXQgZm91bmQgYExpbmVTdHJpbmdgLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgZ2VvbWV0cnkgb2YgdHlwZSBgUG9pbnRgIGJ1dCBmb3VuZCBgTGluZVN0cmluZ2AuXCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #40
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected geometry of type `Point` but found `LineString`.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected geometry of type `Point` but found `LineString`.", r.array(0L));
                 
                 /* Original: r.line(r.point(0,0), r.point(1,0), r.line([0,0], [1,0])) */
                 var obtained = runOrCatch( r.line(r.point(0L, 0L), r.point(1L, 0L), r.line(r.array(0L, 0L), r.array(1L, 0L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjUwIiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDBdLCBbMCwwXSwgWzAsMF0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2x5Z29uKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAwTCksIHIuYXJyYXkoMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0ludmFsaWQgTGluZWFyUmluZy4gIEFyZSB0aGVyZSBhbnRpcG9kYWwgb3IgZHVwbGljYXRlIHZlcnRpY2VzPyBJcyBpdCBzZWxmLWludGVyc2VjdGluZz8nLCBbMF0pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkludmFsaWQgTGluZWFyUmluZy4gIEFyZSB0aGVyZSBhbnRpcG9kYWwgb3IgZHVwbGljYXRlIHZlcnRpY2VzPyBJcyBpdCBzZWxmLWludGVyc2VjdGluZz9cIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, geo/constructors.yaml, #50
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Invalid LinearRing.  Are there antipodal or duplicate vertices? Is it self-intersecting?', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Invalid LinearRing.  Are there antipodal or duplicate vertices? Is it self-intersecting?", r.array(0L));
                 
                 /* Original: r.polygon([0,0], [0,0], [0,0], [0,0]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 0L), r.array(0L, 0L), r.array(0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjUyIiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDFdLCBbMSwwXSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnBvbHlnb24oci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAxTCksIHIuYXJyYXkoMUwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6W1tbMCwwXSwgWzAsMV0sIFsxLDBdLCBbMCwwXV1dLCAndHlwZSc6J1BvbHlnb24nfSkiLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCIkcmVxbF90eXBlJFwiLCBcIkdFT01FVFJZXCIpLndpdGgoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KHIuYXJyYXkoci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAxTCksIHIuYXJyYXkoMUwsIDBMKSwgci5hcnJheSgwTCwgMEwpKSkpLndpdGgoXCJ0eXBlXCIsIFwiUG9seWdvblwiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #52
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon");
                 
                 /* Original: r.polygon([0,0], [0,1], [1,0]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjU0IiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDFdLCBbMSwwXSwgWzAsMF0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2x5Z29uKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDFMLCAwTCksIHIuYXJyYXkoMEwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiKHsnJHJlcWxfdHlwZSQnOidHRU9NRVRSWScsICdjb29yZGluYXRlcyc6W1tbMCwwXSwgWzAsMV0sIFsxLDBdLCBbMCwwXV1dLCAndHlwZSc6J1BvbHlnb24nfSkiLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCIkcmVxbF90eXBlJFwiLCBcIkdFT01FVFJZXCIpLndpdGgoXCJjb29yZGluYXRlc1wiLCByLmFycmF5KHIuYXJyYXkoci5hcnJheSgwTCwgMEwpLCByLmFycmF5KDBMLCAxTCksIHIuYXJyYXkoMUwsIDBMKSwgci5hcnJheSgwTCwgMEwpKSkpLndpdGgoXCJ0eXBlXCIsIFwiUG9seWdvblwiKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #54
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon");
                 
                 /* Original: r.polygon([0,0], [0,1], [1,0], [0,0]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjU2IiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDFdLCBbMSwwXSwgWy0xLDAuNV0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2x5Z29uKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDFMLCAwTCksIHIuYXJyYXkoLTFMLCAwLjUpKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoJ1JlcWxRdWVyeUxvZ2ljRXJyb3InLCAnSW52YWxpZCBMaW5lYXJSaW5nLiAgQXJlIHRoZXJlIGFudGlwb2RhbCBvciBkdXBsaWNhdGUgdmVydGljZXM/IElzIGl0IHNlbGYtaW50ZXJzZWN0aW5nPycsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiSW52YWxpZCBMaW5lYXJSaW5nLiAgQXJlIHRoZXJlIGFudGlwb2RhbCBvciBkdXBsaWNhdGUgdmVydGljZXM/IElzIGl0IHNlbGYtaW50ZXJzZWN0aW5nP1wiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #56
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Invalid LinearRing.  Are there antipodal or duplicate vertices? Is it self-intersecting?', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Invalid LinearRing.  Are there antipodal or duplicate vertices? Is it self-intersecting?", r.array(0L));
                 
                 /* Original: r.polygon([0,0], [0,1], [1,0], [-1,0.5]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(-1L, 0.5)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjU4IiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDFdLCBbMF0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5wb2x5Z29uKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpLCByLmFycmF5KDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHBvaW50IGNvb3JkaW5hdGUgcGFpci4gIEdvdCAxIGVsZW1lbnQgYXJyYXkgaW5zdGVhZCBvZiBhIDIgZWxlbWVudCBvbmUuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCBwb2ludCBjb29yZGluYXRlIHBhaXIuICBHb3QgMSBlbGVtZW50IGFycmF5IGluc3RlYWQgb2YgYSAyIGVsZW1lbnQgb25lLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #58
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected point coordinate pair.  Got 1 element array instead of a 2 element one.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected point coordinate pair.  Got 1 element array instead of a 2 element one.", r.array(0L));
                 
                 /* Original: r.polygon([0,0], [0,1], [0]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjYwIiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oWzAsMF0sIFswLDFdLCBbMCwxLDBdKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucG9seWdvbihyLmFycmF5KDBMLCAwTCksIHIuYXJyYXkoMEwsIDFMKSwgci5hcnJheSgwTCwgMUwsIDBMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHBvaW50IGNvb3JkaW5hdGUgcGFpci4gIEdvdCAzIGVsZW1lbnQgYXJyYXkgaW5zdGVhZCBvZiBhIDIgZWxlbWVudCBvbmUuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCBwb2ludCBjb29yZGluYXRlIHBhaXIuICBHb3QgMyBlbGVtZW50IGFycmF5IGluc3RlYWQgb2YgYSAyIGVsZW1lbnQgb25lLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, geo/constructors.yaml, #60
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected point coordinate pair.  Got 3 element array instead of a 2 element one.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected point coordinate pair.  Got 3 element array instead of a 2 element one.", r.array(0L));
                 
                 /* Original: r.polygon([0,0], [0,1], [0,1,0]) */
                 var obtained = runOrCatch( r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(0L, 1L, 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZ2VvL2NvbnN0cnVjdG9ycy55YW1sIiwiTGluZU51bSI6IjYyIiwiT3JpZ2luYWwiOiJyLnBvbHlnb24oci5wb2ludCgwLDApLCByLnBvaW50KDAsMSksIHIubGluZShbMCwwXSwgWzAsMV0pKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucG9seWdvbihyLnBvaW50KDBMLCAwTCksIHIucG9pbnQoMEwsIDFMKSwgci5saW5lKHIuYXJyYXkoMEwsIDBMKSwgci5hcnJheSgwTCwgMUwpKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIGdlb21ldHJ5IG9mIHR5cGUgYFBvaW50YCBidXQgZm91bmQgYExpbmVTdHJpbmdgLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgZ2VvbWV0cnkgb2YgdHlwZSBgUG9pbnRgIGJ1dCBmb3VuZCBgTGluZVN0cmluZ2AuXCIsIHIuYXJyYXkoMEwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, geo/constructors.yaml, #62
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected geometry of type `Point` but found `LineString`.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected geometry of type `Point` but found `LineString`.", r.array(0L));
                 
                 /* Original: r.polygon(r.point(0,0), r.point(0,1), r.line([0,0], [0,1])) */
                 var obtained = runOrCatch( r.polygon(r.point(0L, 0L), r.point(0L, 1L), r.line(r.array(0L, 0L), r.array(0L, 1L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
