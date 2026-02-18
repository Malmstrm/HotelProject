## Description
 What has been done?
- 
## Ticket Reference
- Ticket ID: [HOTEL-XXX]

## Type of Change
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] Refactoring (code improvement without functional changes)
- [ ] Database migration

## 📋 Pull Request Checklist

### 🏗 Architecture & Standards
- [ ] **Clean Architecture:** Is the code placed in the correct project layer (`Domain`, `Infrastructure`, `Application`, etc.)?
- [ ] **Naming:** Are all classes, variables, and methods named in **English**?
- [ ] **BaseEntity:** Do all new entities inherit from `BaseEntity`?
- [ ] **Enums:** Are enums used correctly with explicit integer values (e.g., `Pending = 1`)?

### 🛠 Technical Quality
- [ ] **Migrations:** Have database migrations been created and verified? (If applicable)
- [ ] **Validation:** Is FluentValidation implemented for new data?
- [ ] **Async/Await:** Are asynchronous patterns used correctly for I/O operations?

### 🧪 Testing & Verification
- [ ] **Build:** Does the solution build without errors or warnings in Rider? (`Ctrl + Shift + B`)
- [ ] **Manual Test:** Have the changes been manually tested or verified in the code?

### 📝 Documentation & Git
- [ ] **Git Flow:** Have I merged the latest `develop` into this branch?
