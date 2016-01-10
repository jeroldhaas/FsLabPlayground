module FsLabPlayground.Tests

open FsLabPlayground
open NUnit.Framework
open FsCheck
open FsCheck.Experimental
open FsCheck.NUnit

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)
