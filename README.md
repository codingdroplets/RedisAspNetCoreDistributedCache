# ASP .Net Core Distributed Cache using Redis

Watch Tutorial Video:

https://www.youtube.com/watch?v=4Br-QnBo6Yw

In this video you will learn how to implement ASP.Net Distributed Caching. We use Redis as the cache data storage. The demo application created is using dotnet5 as the target framework.

Topics Covered:
1. What is Caching?
2. What are the use cases of Caching?
3. How to implement Caching?

#Redis is an open source, in-memory data structure store, used as a database, cache, and message broker. Redis provides data structures such as strings, hashes, lists, sets, sorted sets with range queries, bitmaps, hyperloglogs, geospatial indexes, and streams. Redis has built-in replication, Lua scripting, LRU eviction, transactions, and different levels of on-disk persistence, and provides high availability via Redis Sentinel and automatic partitioning with Redis Cluster.

What is Distributed Caching?
A cache is a component that stores data so future requests for that data can be served faster. This provides high throughput and low-latency access to commonly used application data, by storing the data in memory.
By avoiding the high latency data access of a persistent data store, caching can dramatically improve application responsiveness, if it's well used.

What are the benefits?
- Sharing state between different Servers, Applications, Modules or even components that can be in the same or in different infrastructures.
- Continuous querying for the same data inside Actions, Screens and Web Services especially when the data changes frequently as in a few seconds.
- Storing high transient data, for example, data that is created and deleted after a very short period of time.
