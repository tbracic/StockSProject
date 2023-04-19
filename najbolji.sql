--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2023-02-17 11:23:20

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 216 (class 1259 OID 16435)
-- Name: User; Type: TABLE; Schema: test; Owner: postgres
--

CREATE TABLE test."User" (
    id integer NOT NULL,
    userid integer,
    username character varying(255) DEFAULT NULL::character varying,
    email character varying(255) DEFAULT NULL::character varying
);


ALTER TABLE test."User" OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16434)
-- Name: User_id_seq; Type: SEQUENCE; Schema: test; Owner: postgres
--

CREATE SEQUENCE test."User_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE test."User_id_seq" OWNER TO postgres;

--
-- TOC entry 3329 (class 0 OID 0)
-- Dependencies: 215
-- Name: User_id_seq; Type: SEQUENCE OWNED BY; Schema: test; Owner: postgres
--

ALTER SEQUENCE test."User_id_seq" OWNED BY test."User".id;


--
-- TOC entry 3175 (class 2604 OID 16438)
-- Name: User id; Type: DEFAULT; Schema: test; Owner: postgres
--

ALTER TABLE ONLY test."User" ALTER COLUMN id SET DEFAULT nextval('test."User_id_seq"'::regclass);


--
-- TOC entry 3323 (class 0 OID 16435)
-- Dependencies: 216
-- Data for Name: User; Type: TABLE DATA; Schema: test; Owner: postgres
--

COPY test."User" (id, userid, username, email) FROM stdin;
1	1	Constance Kline	enim.mauris@icloud.ca
2	2	Brianna Foster	in.tempus@hotmail.couk
3	3	Hannah Greer	consectetuer@google.edu
4	4	Marshall Mckenzie	dolor.quisque.tincidunt@protonmail.edu
5	5	Jemima Edwards	neque.sed.dictum@aol.couk
6	6	Mechelle Sosa	iaculis.nec.eleifend@aol.net
7	7	Clayton Casey	dignissim.tempor@protonmail.org
8	8	Nasim Booth	dolor.nulla.semper@hotmail.edu
9	9	Amber Garner	sodales.elit@google.edu
10	10	Cally Gould	felis.donec.tempor@google.net
11	11	Marsden Rice	hendrerit.a.arcu@hotmail.ca
12	12	Denise Everett	augue.ut@outlook.ca
13	13	Fleur Shaffer	convallis.ante@aol.org
14	14	Kyra Knox	arcu.iaculis@yahoo.org
15	15	Asher Holmes	nec.euismod@yahoo.net
16	16	Madison Johnston	mauris@yahoo.com
17	17	Christopher Henderson	mauris@yahoo.com
18	18	Kylan Shannon	sed@icloud.com
19	19	Audra Watts	pharetra.felis.eget@hotmail.com
20	20	Delilah Roth	sit.amet@outlook.ca
21	21	Berk Walters	sodales.at@outlook.ca
22	22	Seth Dennis	gravida.non@google.couk
23	23	Eric Marshall	sit.amet@aol.couk
24	24	Amity Aguirre	nulla@hotmail.net
25	25	Simone Buck	aliquet.libero@aol.org
26	26	Kirk Silva	sollicitudin@icloud.couk
27	27	Fritz Nixon	mollis.non.cursus@outlook.ca
28	28	Cecilia Rivas	pellentesque.ut.ipsum@outlook.net
29	29	Nicole Howe	enim.gravida@hotmail.ca
30	30	Brett Hampton	vehicula@aol.net
31	31	Erica Jimenez	quis.lectus.nullam@hotmail.org
32	32	Avram Decker	nascetur.ridiculus.mus@icloud.com
33	33	Noah Reeves	sed.eu.eros@yahoo.com
34	34	Ross Ryan	feugiat.sed@google.org
35	35	Brett Spence	aliquam@outlook.ca
36	36	Acton Mendoza	ullamcorper.magna@outlook.couk
37	37	Lucian Dorsey	sed.sapien@hotmail.com
38	38	Giselle Nunez	blandit@yahoo.net
39	39	Avram Curry	non.arcu@yahoo.edu
40	40	Maile Watson	a@icloud.net
41	41	Sylvia Johns	non.enim@aol.org
42	42	Henry Mcfadden	sagittis@yahoo.edu
43	43	Curran Cole	quam.a@outlook.com
44	44	Joel Bartlett	facilisis.non@icloud.ca
45	45	Ursa Valdez	fusce.feugiat.lorem@outlook.couk
46	46	Lesley Lester	sodales.at@outlook.org
47	47	Sheila Floyd	urna.suscipit.nonummy@hotmail.edu
48	48	Laurel Romero	at@aol.org
49	49	Dahlia Oneal	consequat.enim@icloud.ca
50	50	Rudyard Jefferson	facilisis.suspendisse@google.com
51	51	Brianna Huber	nullam.scelerisque.neque@aol.couk
52	52	Jesse Silva	dictum@icloud.net
53	53	Desiree Cote	in@yahoo.net
54	54	Tobias Bright	eu.neque@outlook.couk
55	55	Burton Arnold	ut.quam@outlook.edu
56	56	Kessie Shepherd	nunc.ac@hotmail.couk
57	57	Zenaida Hewitt	condimentum.donec@google.org
58	58	Griffith Roberson	et.ultrices@icloud.org
59	59	Amber Langley	consectetuer.rhoncus.nullam@hotmail.net
60	60	Flavia Medina	ullamcorper@icloud.couk
61	61	Carissa Mcfadden	commodo.tincidunt@hotmail.net
62	62	Zeph Keller	sed@outlook.couk
63	63	Kimberley Alvarez	fringilla.euismod@hotmail.couk
64	64	Marvin Bean	cursus.a@icloud.org
65	65	Mallory Craft	ultricies@yahoo.com
66	66	Erasmus Cook	tristique@aol.net
67	67	Odette Simon	rhoncus.nullam@aol.ca
68	68	Louis Witt	donec@outlook.net
69	69	Britanney Decker	vel.venenatis.vel@yahoo.ca
70	70	Magee Dillon	etiam.ligula@icloud.com
71	71	Sawyer Mcknight	sapien.molestie@hotmail.couk
72	72	Ishmael Wolfe	nec.euismod.in@outlook.net
73	73	Blaze Meyer	orci.tincidunt.adipiscing@outlook.com
74	74	Wesley Webster	urna.convallis@outlook.couk
75	75	Timon Mccoy	quisque@outlook.ca
76	76	Brian Chen	montes.nascetur@icloud.couk
77	77	Nero Fitzgerald	tortor.dictum@protonmail.org
78	78	Eliana Dejesus	elit.nulla.facilisi@icloud.com
79	79	Dexter Adkins	ridiculus@hotmail.edu
80	80	Chester Graham	adipiscing@hotmail.net
81	81	Noelani Hinton	tincidunt.pede.ac@yahoo.edu
82	82	Aimee Cortez	senectus@aol.ca
83	83	Edan Berry	non.justo@protonmail.couk
84	84	Zeph Clemons	dictum.ultricies@icloud.org
85	85	Sharon Blackburn	tempor@google.net
86	86	Amber Mcneil	elit.pharetra@protonmail.com
87	87	Rafael Sheppard	fusce.diam@aol.net
88	88	Giacomo Prince	convallis@google.com
89	89	Shafira Solis	lorem.vitae.odio@icloud.org
90	90	Ursa Clayton	adipiscing.lobortis@hotmail.net
91	91	Baxter Burton	odio.auctor@aol.org
92	92	Knox Lynch	aenean.egestas.hendrerit@aol.ca
93	93	Marcia Ewing	est.nunc@outlook.edu
94	94	Charity Sargent	aliquam.adipiscing@aol.ca
95	95	Conan Baird	mi@yahoo.com
96	96	Cade Snider	eu.lacus.quisque@icloud.net
97	97	Orla Reeves	nibh.quisque@hotmail.ca
98	98	Valentine Hurst	quam@hotmail.edu
99	99	Macon Walters	montes.nascetur@outlook.net
100	100	Julie Blair	etiam@outlook.edu
101	101	Darrel Trujillo	lectus.justo.eu@google.couk
102	102	Petra Mccormick	ac.libero@protonmail.com
103	103	Fatima Glass	dolor@icloud.com
104	104	Nathan Becker	enim@google.net
105	105	Callum Fields	eu.euismod@google.org
106	106	Alexandra Rose	nisi.mauris@yahoo.edu
107	107	Jasmine Smith	mi.felis@icloud.edu
108	108	Chase Nielsen	cursus.integer@hotmail.ca
109	109	Christen Conrad	hendrerit.donec.porttitor@icloud.ca
110	110	Jonas Joseph	integer.in@outlook.net
111	111	Carla Macdonald	ante.maecenas.mi@aol.edu
112	112	Mia Schmidt	in.lobortis.tellus@aol.com
113	113	Cassidy Downs	pede.praesent@protonmail.org
114	114	Kirk Foreman	lacus@yahoo.edu
115	115	Odessa Mullins	pede.nunc.sed@google.ca
116	116	Ryder Cash	curabitur@icloud.ca
117	117	Angelica Schmidt	condimentum.eget@yahoo.edu
118	118	Hall Rich	a.purus.duis@icloud.edu
119	119	Duncan Mathis	lorem.ipsum@hotmail.com
120	120	Zephr Reilly	pretium.neque@google.com
121	121	Rahim Pruitt	tempus.non@yahoo.edu
122	122	Henry Jackson	primis.in@google.edu
123	123	Quinn Beck	tincidunt.dui@google.net
124	124	Priscilla Graves	nisl.nulla@aol.edu
125	125	Neve Mcknight	ut.molestie@protonmail.ca
126	126	Sonya Williams	etiam.imperdiet@google.net
127	127	Rajah Glenn	eleifend.nunc@protonmail.ca
128	128	Barbara Hooper	augue.ac@hotmail.com
129	129	Kermit Roach	sodales.at@hotmail.org
130	130	Faith Berg	mauris.ut@aol.net
131	131	Rudyard Drake	nec.tempus@outlook.edu
132	132	Dawn Townsend	egestas.fusce.aliquet@protonmail.org
133	133	Shay Blanchard	venenatis.a@hotmail.net
134	134	Murphy Cook	feugiat.lorem@google.edu
135	135	Hilary Baker	donec.non@yahoo.org
136	136	Nell Rocha	risus.a.ultricies@yahoo.couk
137	137	Stephanie Goff	et.ipsum.cursus@yahoo.ca
138	138	Ora Cooley	fringilla.euismod.enim@yahoo.net
139	139	Xander Abbott	ante.blandit@protonmail.net
140	140	Guinevere Montoya	elit.curabitur.sed@protonmail.couk
141	141	Hakeem Garrison	et.netus@aol.ca
142	142	Shelby Ryan	amet.consectetuer@protonmail.edu
143	143	Austin Bowers	consequat.purus.maecenas@protonmail.edu
144	144	Gwendolyn Wright	accumsan@icloud.edu
145	145	Kelsie Donovan	dictum.eu@outlook.org
146	146	Lucas Cooper	ac.turpis.egestas@outlook.edu
147	147	Mariko Phillips	nunc.ac@yahoo.edu
148	148	Britanni Conley	vulputate.velit@aol.com
149	149	Karina Pitts	pede.praesent.eu@google.net
150	150	Odette Vinson	malesuada.ut@outlook.couk
151	151	Kenyon Fitzgerald	suscipit@icloud.couk
152	152	Stella Everett	ut.quam.vel@hotmail.org
153	153	Miriam Knowles	sit.amet@outlook.couk
154	154	Grace Williamson	vestibulum.lorem@icloud.net
155	155	Addison Davis	mattis.cras@aol.couk
156	156	Mara Floyd	et.risus@outlook.net
157	157	Rafael Ayala	vestibulum@icloud.com
158	158	Herman Mcguire	quam.curabitur@protonmail.com
159	159	Melyssa Mullen	sit.amet.nulla@outlook.edu
160	160	Kay Mullen	tempor.erat@aol.net
161	161	Martina Brady	neque.vitae@aol.edu
162	162	Alec Leon	nibh.dolor@icloud.net
163	163	Sophia Sosa	enim.sed@hotmail.edu
164	164	Karen Holden	luctus.ipsum.leo@google.com
165	165	Jonah Adkins	dolor.fusce.mi@yahoo.couk
166	166	Felix Prince	curabitur.vel.lectus@outlook.edu
167	167	Brenda Mccoy	quisque@protonmail.ca
168	168	Odette Little	orci.adipiscing@aol.couk
169	169	Christine Taylor	velit.dui@icloud.ca
170	170	Kaitlin Hopper	augue.eu@outlook.edu
171	171	Adele Berg	quam.quis.diam@icloud.edu
172	172	Aladdin Calderon	suspendisse.commodo.tincidunt@outlook.ca
173	173	Nell Oneal	nulla.facilisis.suspendisse@icloud.couk
174	174	Lacey Scott	mi@google.com
175	175	Remedios Coleman	metus.aenean@outlook.net
176	176	Quyn Thornton	mauris@icloud.com
177	177	Christian Christian	cras.pellentesque@outlook.edu
178	178	Scott Short	risus.morbi@hotmail.edu
179	179	Bryar Jacobs	amet.risus.donec@protonmail.net
180	180	Dolan Hale	ut@hotmail.couk
181	181	Sybil Rose	arcu.sed@hotmail.couk
182	182	Leah Rocha	at.iaculis.quis@aol.couk
183	183	Amos Stephenson	dui@protonmail.edu
184	184	Mari Colon	neque@hotmail.couk
185	185	Carter Knowles	ipsum.donec@yahoo.org
186	186	Lucas Terry	lobortis@outlook.net
187	187	Bo Thomas	donec.nibh@icloud.net
188	188	Ezekiel Maynard	eget.nisi@hotmail.couk
189	189	Jena Moon	dis.parturient.montes@icloud.ca
190	190	Blaze Bates	tristique.pellentesque@yahoo.couk
191	191	Henry Mayer	massa@outlook.couk
192	192	Denise Nichols	vestibulum@outlook.com
193	193	Ray Slater	tincidunt.adipiscing.mauris@google.org
194	194	Jemima Walton	pede.ac@icloud.ca
195	195	Erin Freeman	tincidunt@icloud.com
196	196	Emi Suarez	quis@icloud.couk
197	197	Kathleen Cameron	ornare.lectus@hotmail.edu
198	198	Jorden Weaver	luctus@aol.net
199	199	Ebony Oneal	dolor.dolor@yahoo.couk
200	200	Heather Chan	integer@yahoo.com
\.


--
-- TOC entry 3330 (class 0 OID 0)
-- Dependencies: 215
-- Name: User_id_seq; Type: SEQUENCE SET; Schema: test; Owner: postgres
--

SELECT pg_catalog.setval('test."User_id_seq"', 200, true);


--
-- TOC entry 3179 (class 2606 OID 16444)
-- Name: User User_pkey; Type: CONSTRAINT; Schema: test; Owner: postgres
--

ALTER TABLE ONLY test."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (id);


-- Completed on 2023-02-17 11:23:20

--
-- PostgreSQL database dump complete
--

