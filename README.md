# GiftAidCalculator
Small dojo-style exercise - incrementally adding functionality to some code

##General
This little exercise is about calculating gift aid (a tax calculation done against a donation).  
The idea is to iteratively add functionality, while maintaining clean, robust code.  
Generally, the formula for a gift aid is `[Donation Amount] * ( [TaxRate] / (100 - [TaxRate]) )`, and this is the code's starting point.

##Stages
The code went through several iterations, each one with implementing a specific requirement.
###Stage 1 
**Requirement:** Calculate gift aid according to 20% tax.  
**Implementation:** I've extracted the calculation to its own class (`Calculator`), since it's a separate concern.  
This class then implemented the calculation. I've added a couple of test to verify.  
###Stage 2
**Requirement:** Ability to configure tax rate (rather than having a constant one)  
**Implementation:** This is a simple case of a dependency (in this case - a very simple one - just a number), that I've extracted from the `Calculator` class and moved to its constructor.  
That way, the tax rate can be read from somewhere and injected into the calculator.  
I've changed the existing tests to verify that different tax rates yield different results.  
###Stage 3
**Requirement:** Display the donation amount rounded to 2 decimal places  
**Implementation:** I've separated the concern of presentation into its own class, `AmountPresenter`, which receives a number and returns the rounded number for display.  
A very trivial implementation, and some tests to verify.  
###Stage 4
**Requirement:** Add some promotions, based on the type of the event the donation relates to.  
If the event is of type 'running' - add 5% to the calculated gift aid. if the event is of type 'swimming' - add 3%.
**Implementation:** There are a few new concerns here - 1. Applying a promotion to a certain donation, 2. Understanding what kind of promotion is relevant to a donation.  

For problem #1, I wouldn't put that directly into the `Calculator` class, since it's bound to make it much more complicated (`if [this type of promotion] do [this]...`).  
Instead, it's much cleaner to use a type of Visitor DP to inject this behaviour into the `Calculator`.   
So I've created the `IPromotion` interface, with a single method, `Apply`, which takes a calculated donation, and applies the promotion to it.  
That way, all the `Calculator` has to do is use a given `IPromotion` instance on the donation it has calculated.  

For problem #2, I simply created a `PromotionsFactory`, which accepts a type of event, and returns the correct promotion for this event.

##What can be improved
This exercise is not production-level code yet. A couple of things that are incomplete are:  
* Input verification - in `Program`, we don't verify the user's input. Usage of `TryParse` with proper messages to the user would be a good solution.
* Primitives - all values passing around are simple `decimal`s. However, that means that we can have a tax rate of `-5343%`, for example.
A good way to avoid this is to use [Value Objects](http://martinfowler.com/bliki/ValueObject.html).
