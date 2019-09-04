# Toucan Testing

## Quick Start
- Fork and clone
- `npm install`
- `npm start`

## Application Architecture
Toucan Testing is built using modern angular. Various modules exist for different purposes. Modules can be thought of similarly to N-tier architecture.

## State Management
Toucan Testing is built with NgRx. You should be familiar with selectors, actions, reducers, and effects.

State management is useful for sharing data between components. It isn't necessary to be used in all situations.

## Modules

### App
The app module is the parent of all other modules. Anything declared or imported into the app module will be available throughout the application (assuming). **Import 3rd party modules here.**

### Routing
Make use of the auth guard and page routes here. Every page component created will need to be added here in order to work.

### Pages
Use this module to add pages. The folder structure should follow the url structure. Consider the following example for:

`toucantesting.com/login`
`toucantesting.com/dashboard`
`toucantesting.com/suites`
`toucantesting.com/suites/{id}`
`toucantesting.com/runs`
`toucantesting.com/runs/{id}`

```
<!-- ROOT DIR /src/app/pages -->
/login
|-- login.component.html
|-- login.component.scss
|-- login.component.spec.ts
|-- login.component.ts
/dashboard
|-- dashboard.component.html
|-- dashboard.component.scss
|-- dashboard.component.spec.ts
|-- dashboard.component.ts
/runs
|-- runs.component.html
|-- runs.component.scss
|-- runs.component.spec.ts
|-- runs.component.ts
/suites
|-- suites.component.html
|-- suites.component.scss
|-- suites.component.spec.ts
|-- suites.component.ts
|-- /suite
|----- suite.component.html
|----- suite.component.scss
|----- suite.component.spec.ts
|----- suite.component.ts
/shared
|-- /modules
|----- modules.component.html
|----- modules.component.scss
|----- modules.component.spec.ts
|----- modules.component.ts
|---- /scenarios
|------- scenarios.component.html
|------- scenarios.component.scss
|------- scenarios.component.spec.ts
|------- scenarios.component.ts
|--------- /setup
|--------- /actions
|--------- /expectations
```
### Store
The store module should be used for selectors, actions, reducers and effects. 

### Shared
Anything that will be used across various modules, pages, or components.

#### Components
This is where components should live. Examples include modals/dialogs, cards, panels, etc.

#### Models
All models should live here with the exception of NgRx State Models. Upon model creation, an entry for the model must manually be entered into the `models/index.ts` file.

#### Services
Services that communicate with the API should live here.

## Package Management
DO NOT USE YARN! Package management is handled with `npm`

## Configurations

### Path Aliases
Path aliases are utilized to simplify importing internal modules. These can be configured in the `tsconfig.json` file's `compilerOptions.paths` section.

### Environments
Angular can swap the `environments/environment.ts` file to handle different builds. Environment configurations can be added in the `angular.json` file.

### Scripts and Styles

#### Third-Party
Third-party scripts and styles should primarily be placed in the `angular.json` file

#### Internal
Internal styles should go with their component's `.scss` file. There's `styles.scss` file that imports shared styles from `assets/styles`

## Development server
Run `npm start` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Build
Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.
