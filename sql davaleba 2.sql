DROP TABLE IF EXISTS students;
CREATE TABLE students(
   sid  int  not null, 
   name text not null,
 primary key(sid)
);

CREATE TABLE teachers(
   tid  int  not null,
   name text not null, 
 primary key(tid)
);

INSERT INTO students (sid, name) VALUES(1, 'Giorgi');
INSERT INTO students (sid, name) VALUES(2, 'Lasha');
INSERT INTO students (sid, name) VALUES(3, 'Teo');
INSERT INTO students (sid, name) VALUES(4, 'Nika');
INSERT INTO students (sid, name) VALUES(5, 'Lika');
INSERT INTO students (sid, name) VALUES(6, 'Salome');
INSERT INTO students (sid, name) VALUES(7, 'Ani');

select *
from Students;

INSERT INTO teachers (tid, name) VALUES (1, 'Zaza');
INSERT INTO teachers (tid, name) VALUES (2, 'Nunuka');
INSERT INTO teachers (tid, name) VALUES (3, 'Tato');
INSERT INTO teachers (tid, name) VALUES (4, 'Luka');

INSERT INTO teaching (studentID, teacherID, ) VALUES (1, 2,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (1, 2,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (7, 4,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (7, 3,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (6, 2,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (2, 4,);
INSERT INTO teaching (studentID, teacherID, ) VALUES (3, 4,);

select name
from students 
where sid in 
  (select studentID
   from teaching
   where teacherID in 
     (select tid
      from teachers
      from teaching
      where name = 'Giorgi'
      )
   );
