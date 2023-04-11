PGDMP                         {            Recipes    15.1    15.1 4    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    25196    Recipes    DATABASE     }   CREATE DATABASE "Recipes" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Recipes";
                postgres    false            �            1259    25198    cookery    TABLE     ^   CREATE TABLE public.cookery (
    id integer NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public.cookery;
       public         heap    postgres    false            �            1259    25197    cookery_id_seq    SEQUENCE     �   CREATE SEQUENCE public.cookery_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.cookery_id_seq;
       public          postgres    false    215            �           0    0    cookery_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.cookery_id_seq OWNED BY public.cookery.id;
          public          postgres    false    214            �            1259    25281    dish_ingredient    TABLE     �   CREATE TABLE public.dish_ingredient (
    id_dish integer NOT NULL,
    id_ingridient integer NOT NULL,
    quantity numeric,
    id_measure_unit integer NOT NULL
);
 #   DROP TABLE public.dish_ingredient;
       public         heap    postgres    false            �            1259    25259 	   dish_tags    TABLE     ]   CREATE TABLE public.dish_tags (
    id_dish integer NOT NULL,
    id_tag integer NOT NULL
);
    DROP TABLE public.dish_tags;
       public         heap    postgres    false            �            1259    25225    dishes    TABLE     �   CREATE TABLE public.dishes (
    id integer NOT NULL,
    name character varying NOT NULL,
    description text,
    recipe text,
    id_cookery integer,
    cooking_time integer
);
    DROP TABLE public.dishes;
       public         heap    postgres    false            �            1259    25224    dishes_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dishes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.dishes_id_seq;
       public          postgres    false    221            �           0    0    dishes_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.dishes_id_seq OWNED BY public.dishes.id;
          public          postgres    false    220            �            1259    25301 	   favorites    TABLE     P   CREATE TABLE public.favorites (
    id integer NOT NULL,
    date_added date
);
    DROP TABLE public.favorites;
       public         heap    postgres    false            �            1259    25207    ingredients    TABLE     b   CREATE TABLE public.ingredients (
    id integer NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public.ingredients;
       public         heap    postgres    false            �            1259    25206    ingredients_id_seq    SEQUENCE     �   CREATE SEQUENCE public.ingredients_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.ingredients_id_seq;
       public          postgres    false    217            �           0    0    ingredients_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.ingredients_id_seq OWNED BY public.ingredients.id;
          public          postgres    false    216            �            1259    25273    measure_units    TABLE     [   CREATE TABLE public.measure_units (
    id integer NOT NULL,
    name character varying
);
 !   DROP TABLE public.measure_units;
       public         heap    postgres    false            �            1259    25272    measure_units_id_seq    SEQUENCE     �   CREATE SEQUENCE public.measure_units_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.measure_units_id_seq;
       public          postgres    false    224            �           0    0    measure_units_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.measure_units_id_seq OWNED BY public.measure_units.id;
          public          postgres    false    223            �            1259    25216    tags    TABLE     Z   CREATE TABLE public.tags (
    id integer NOT NULL,
    tag character varying NOT NULL
);
    DROP TABLE public.tags;
       public         heap    postgres    false            �            1259    25215    tags_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tags_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.tags_id_seq;
       public          postgres    false    219            �           0    0    tags_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.tags_id_seq OWNED BY public.tags.id;
          public          postgres    false    218            ,           2604    25201 
   cookery id    DEFAULT     h   ALTER TABLE ONLY public.cookery ALTER COLUMN id SET DEFAULT nextval('public.cookery_id_seq'::regclass);
 9   ALTER TABLE public.cookery ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    214    215    215            /           2604    25228 	   dishes id    DEFAULT     f   ALTER TABLE ONLY public.dishes ALTER COLUMN id SET DEFAULT nextval('public.dishes_id_seq'::regclass);
 8   ALTER TABLE public.dishes ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    221    221            -           2604    25210    ingredients id    DEFAULT     p   ALTER TABLE ONLY public.ingredients ALTER COLUMN id SET DEFAULT nextval('public.ingredients_id_seq'::regclass);
 =   ALTER TABLE public.ingredients ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217            0           2604    25276    measure_units id    DEFAULT     t   ALTER TABLE ONLY public.measure_units ALTER COLUMN id SET DEFAULT nextval('public.measure_units_id_seq'::regclass);
 ?   ALTER TABLE public.measure_units ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    224    224            .           2604    25219    tags id    DEFAULT     b   ALTER TABLE ONLY public.tags ALTER COLUMN id SET DEFAULT nextval('public.tags_id_seq'::regclass);
 6   ALTER TABLE public.tags ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    218    219            �          0    25198    cookery 
   TABLE DATA           +   COPY public.cookery (id, name) FROM stdin;
    public          postgres    false    215   18       �          0    25281    dish_ingredient 
   TABLE DATA           \   COPY public.dish_ingredient (id_dish, id_ingridient, quantity, id_measure_unit) FROM stdin;
    public          postgres    false    225   N8       �          0    25259 	   dish_tags 
   TABLE DATA           4   COPY public.dish_tags (id_dish, id_tag) FROM stdin;
    public          postgres    false    222   k8       �          0    25225    dishes 
   TABLE DATA           Y   COPY public.dishes (id, name, description, recipe, id_cookery, cooking_time) FROM stdin;
    public          postgres    false    221   �8       �          0    25301 	   favorites 
   TABLE DATA           3   COPY public.favorites (id, date_added) FROM stdin;
    public          postgres    false    226   �8       �          0    25207    ingredients 
   TABLE DATA           /   COPY public.ingredients (id, name) FROM stdin;
    public          postgres    false    217   �8       �          0    25273    measure_units 
   TABLE DATA           1   COPY public.measure_units (id, name) FROM stdin;
    public          postgres    false    224   �8       �          0    25216    tags 
   TABLE DATA           '   COPY public.tags (id, tag) FROM stdin;
    public          postgres    false    219   �8       �           0    0    cookery_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.cookery_id_seq', 1, false);
          public          postgres    false    214            �           0    0    dishes_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.dishes_id_seq', 1, false);
          public          postgres    false    220            �           0    0    ingredients_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.ingredients_id_seq', 1, false);
          public          postgres    false    216            �           0    0    measure_units_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.measure_units_id_seq', 1, false);
          public          postgres    false    223            �           0    0    tags_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.tags_id_seq', 1, false);
          public          postgres    false    218            2           2606    25205    cookery cookery_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.cookery
    ADD CONSTRAINT cookery_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.cookery DROP CONSTRAINT cookery_pkey;
       public            postgres    false    215            8           2606    25232    dishes dishes_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.dishes
    ADD CONSTRAINT dishes_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.dishes DROP CONSTRAINT dishes_pkey;
       public            postgres    false    221            4           2606    25214    ingredients ingredients_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.ingredients
    ADD CONSTRAINT ingredients_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.ingredients DROP CONSTRAINT ingredients_pkey;
       public            postgres    false    217            :           2606    25280     measure_units measure_units_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.measure_units
    ADD CONSTRAINT measure_units_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.measure_units DROP CONSTRAINT measure_units_pkey;
       public            postgres    false    224            6           2606    25223    tags tags_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.tags
    ADD CONSTRAINT tags_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.tags DROP CONSTRAINT tags_pkey;
       public            postgres    false    219            >           2606    25286 ,   dish_ingredient dish_ingredient_id_dish_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dish_ingredient
    ADD CONSTRAINT dish_ingredient_id_dish_fkey FOREIGN KEY (id_dish) REFERENCES public.dishes(id);
 V   ALTER TABLE ONLY public.dish_ingredient DROP CONSTRAINT dish_ingredient_id_dish_fkey;
       public          postgres    false    221    225    3128            ?           2606    25291 2   dish_ingredient dish_ingredient_id_ingridient_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dish_ingredient
    ADD CONSTRAINT dish_ingredient_id_ingridient_fkey FOREIGN KEY (id_ingridient) REFERENCES public.ingredients(id);
 \   ALTER TABLE ONLY public.dish_ingredient DROP CONSTRAINT dish_ingredient_id_ingridient_fkey;
       public          postgres    false    217    3124    225            @           2606    25296 4   dish_ingredient dish_ingredient_id_measure_unit_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dish_ingredient
    ADD CONSTRAINT dish_ingredient_id_measure_unit_fkey FOREIGN KEY (id_measure_unit) REFERENCES public.measure_units(id);
 ^   ALTER TABLE ONLY public.dish_ingredient DROP CONSTRAINT dish_ingredient_id_measure_unit_fkey;
       public          postgres    false    225    224    3130            <           2606    25262     dish_tags dish_tags_id_dish_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dish_tags
    ADD CONSTRAINT dish_tags_id_dish_fkey FOREIGN KEY (id_dish) REFERENCES public.dishes(id);
 J   ALTER TABLE ONLY public.dish_tags DROP CONSTRAINT dish_tags_id_dish_fkey;
       public          postgres    false    222    3128    221            =           2606    25267    dish_tags dish_tags_id_tag_fkey    FK CONSTRAINT     |   ALTER TABLE ONLY public.dish_tags
    ADD CONSTRAINT dish_tags_id_tag_fkey FOREIGN KEY (id_tag) REFERENCES public.tags(id);
 I   ALTER TABLE ONLY public.dish_tags DROP CONSTRAINT dish_tags_id_tag_fkey;
       public          postgres    false    3126    219    222            ;           2606    25233    dishes dishes_id_cookery_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dishes
    ADD CONSTRAINT dishes_id_cookery_fkey FOREIGN KEY (id_cookery) REFERENCES public.cookery(id);
 G   ALTER TABLE ONLY public.dishes DROP CONSTRAINT dishes_id_cookery_fkey;
       public          postgres    false    215    221    3122            A           2606    25304    favorites favorites_id_fkey    FK CONSTRAINT     v   ALTER TABLE ONLY public.favorites
    ADD CONSTRAINT favorites_id_fkey FOREIGN KEY (id) REFERENCES public.dishes(id);
 E   ALTER TABLE ONLY public.favorites DROP CONSTRAINT favorites_id_fkey;
       public          postgres    false    226    221    3128            �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �     