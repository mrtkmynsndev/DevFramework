# DevFramework
N-Tier Layered Architecture RoadMap
- Understanding Tier and Layer
- Dividing Application into multiple layers
- Developing an application using Layered Architecture
  - Creating Core Layer
  - Creating DataAccess Layer
  - Creating DataAccess Unit Test Layer
  - Creating Business Layer
  - Creating Business Unit Test Layer
  - Creating Entities Layer
  - Creating Web UI Layer
  - Creating Web UI Unit Test Layer
  - Creating Web Api Layer
  - Creating Web Api Unit Test Layer
  - Creating WCF Layer
  
1. Core Layer
- DataAccess
   - Generic Repository Implementation
   - Queryable Repository Implementation
   - EntityFramework Generic Repository Implementation
   - NHibernate Generic Repository Implementation
 - Entities
   - Entity Implementation
   - Auditable Entity Implementation
   - Specification Entity Implementation
 - Cross Cutting Concerns
   - Fluent Validation Implementation
- Aspect Oriented Programming - Aspects
   - Postsharp Implementation
   
   
2. DataAccess Layer
   - EntityFramework Dal Implementation
   - EntityFramework Mappings
   - NHibernate Dal Implementation
   - NHibernate Provider
   - NHibernate Mappings
   
3. DataAccess Test Layer
   - EntityFramework Data Access Unit Test Scenario Implementation
   - NHibernate Data Access Unit Test Scenario Implementation
   
4. Business Layer
- Validation Rules
   - Fluent Validation Validator Rules Implementation  
- Dependency Resolver
   - Ninject Module Implementation  
   
5. Business Test Layer
   - Moq Framework Implementation
   - Managers Business Unit Test Scenario Implementation   

5. Entities Layer
   - Complex Type Implementation
   - Concrete Implementation
