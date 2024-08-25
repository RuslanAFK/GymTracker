# GymTracker Requirements (Basic)

Versions:

- V1 - personal use.
- V2 - multiuser non-profit use.
- V3 - commercial use.

The site consists of several pages:

1. Login (V2)
2. Signup (V2)
3. Last progress
4. Exercise page

For V1 Time management is set as UTC to save and to show to user. Warning should be added. Later to show should be in local time.

About archiving of records: in V1 they can only be archived. Unarchiving and showing stats of any kind and which uses archived data is supported in latter versions.

### Login (V2)

Has layout: email and password. 

Has buttons below: Login (primary), Sign up and  Forgot password.

### Signup (V2)

Has layout: email, name, password, confirm password.

Has buttons below: Signup (primary) and Login.

### Last progress

Has layout: boxes with All info for all exercises, ordered by last detection.

All info consists of: Exercise name, Progress in Kg by default.

Has search box for Exercise name, and Kg→Lb→Default switch for Progress.

Also has a switch to view full details about exercises: Weight per one side, number of sides (1/2), and additional weight (e.g. rack for leg press).

Boxes link to Exercise page.

Has link to Add record page.

### Exercise page

Has full exercise info: Exercise name, Weight per one side, number of sides (1/2), and additional weight, and Notes.

Has Kg→Lb→Default switch for Progress (for both info and diagram).

Has exercise last history with same layout as Last progress but without name search.

Also has a switch for viewing tree as a diagram (line or bar).

Has link to Add record (simplified) page.

In last history records can be clicked and redirected to Record page.

Has button: Redirect to edit.

### Edit exercise

Exercise notes and name can be edited.

Has buttons: Save, Cancel, And Archive exercise.

### Add record

Simplified version have Exercise set by default.

Has form with: Description, Weight, Unit. Additional weight. Date is set as now.

Has button to save and cancel.

### Record page

Has form with: Description, Weight, Unit. Additional weight. Date is set as now. All of them are prefilled and can be edited.

Has  button to save, cancel and Delete record.
