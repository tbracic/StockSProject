PGDMP                         {            test    15.1    15.1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                        0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16405    test    DATABASE        CREATE DATABASE test WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE test;
                test    false            �            1259    16469    User    TABLE     �   CREATE TABLE test."User" (
    id integer NOT NULL,
    userid integer,
    username character varying(255) DEFAULT NULL::character varying,
    email character varying(255) DEFAULT NULL::character varying
);
    DROP TABLE test."User";
       test         heap    postgres    false            �            1259    16468    User_id_seq    SEQUENCE     �   CREATE SEQUENCE test."User_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE test."User_id_seq";
       test          postgres    false    216                       0    0    User_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE test."User_id_seq" OWNED BY test."User".id;
          test          postgres    false    215            g           2604    16472    User id    DEFAULT     b   ALTER TABLE ONLY test."User" ALTER COLUMN id SET DEFAULT nextval('test."User_id_seq"'::regclass);
 6   ALTER TABLE test."User" ALTER COLUMN id DROP DEFAULT;
       test          postgres    false    215    216    216            �          0    16469    User 
   TABLE DATA           ;   COPY test."User" (id, userid, username, email) FROM stdin;
    test          postgres    false    216   m
                  0    0    User_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('test."User_id_seq"', 200, true);
          test          postgres    false    215            k           2606    16478    User User_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY test."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (id);
 :   ALTER TABLE ONLY test."User" DROP CONSTRAINT "User_pkey";
       test            postgres    false    216            �   �  x�m��r�H҅�KO�'@p_���R����L�M	(��Pl,�駟/ Y�'"3��ɪ<�'O&<Vcu튪�Eb���F���q���V_l��&�}1QuUZ]:�sUmJe��6�����\�k�ŉk�/�j���]��4<��&�Mݘ��ֹmfb�635SO��v:ˢ�����Q��\������ĵ-�6E�e_���g��s5W&���n�O]��*�|�2i�ڤn�/�uGZ��z2��d��6�����l&�Mf�)R�|aꋥZ��L���ZW�R�-lU��+�Ӹr{�R+�����ʹz�]�h�Ls�|������j�.�WSF_uY�ʥ:3G�u��Ha��}uM��7#�N��;K���|<V�55E�b�vܬ4��c�2iN`��Da7 ^���Ô���n�������Μ{�Nv����6;�������8�.j�'���x(u�X��J~3����wε��vY�½�r#����.��WZ(�I����#[]��m�K\~1^*�z�����-77e�?^)���B�S<D��]Y+�I��]ו��4*u�b`��2?���v�_f����A%a�� ���®L���fRu�_��&jc�]D`�������9n�����Ta��M���N?}���La����嶱ei�O��-$ޓ��66'Ţ�&yW:�Vg��uG�'�=Zه�dCb�&��)���K�ݑ���g�S q>q�G�4e���^)��$6��$���^J�4��Ա�Wx�!�m��{��Y�0�#�]I�G�:�K:}��%E���c�IHu�`sS�_JH)Π��jk;?~�d:Q��G�s ��JU�*��ʸ��|?̛*L�)t9U�N2Ƙ�@�41�3v:S؋����x��Z]�����0WX{�����-|:#<](�2�{�J�/��}W�U���ЧxV_*�[���W
+�I+�����t���p���s#�{��R��T�ӵ��h]7eyP���ڇ|�)�o6R�R˺��|�l���!� S<7�o�y:�(2(t�7�B���[[�GN�5U��^�EJ��q�/f4��zp&��tYgB�oZ2�j�9h�������t�/��D�!�:Z�ɇQ�-��T�9D��zC@�ZK�mv���2wHUS�~��)~���a�xf+�}�����I2��S��
��;)�?
���y����v��^��@�����NB�ە9�U~1+���ͫԉϾ��d�*_供��k>Q؃��:��|���nLe�@X4J�r�¾�W���lw����_�0G^PFM)rY����ȫ���9��X;#}'�6E�d(��K���:�7}��Tȅ��==���Ja_K��fki(�m���&�a&sd��Z�{Y�M|�a ��r��w��,F
�˴�ѓ���0`��Xa����cE-���m���� E�B�o���/�
{�rI�K@.�hJ[l�(�^⺘��ב�����v�X��Y��Dct��u��j�њ�fH���+x�r�Ea�d��Y*쏔�d�S��������¾9���[�ö�X+�dD�ܺk&�?h:����S֟Q_,Gj)��%�o���K�dv+,h.˱�6��@N����-e��`ƚa8���������7
���
���*�*ӿy��(W&��1�moa�b;���La?Z��a^=�y�:��av,�
�.��&�;�nD��r�0O-�5��!�!��� �����z��;��֔���5_�ę�_�v;�\7�/C�)����o��Za7�'7�.�wK�:��9�F
��f'�ӹ
���j��g��.lto1���Mj��N�m5Q�%d#�X�VE~���u5U�m������W����c��)̗�uf�r��q|*���Vs�!�K�#Y��W�V��/���Z{J
z[�^z�_��
{�o��¿{�Q�fS���b&4�$�O��O(etJ��=��
�!Ǣ�7��V�S��(̜Z�m=R�����`F�%ض��+�J��h�����u�$+��x=Q�LQѷC��1]����^��ѮGp=U\�J�n?9���X�Ѡm�g
�&�2lt���B1,��{�
�v�����8�i�
��)lXXf.骠�Et��Ra�ȖN��uw|2����N��2��C�We�i�qzͭ��8Q�~�Y�L�#��Hj$m�2� F��4~�KK���/![��_��`���?%W=M���	*釧�����;h>���LWU�<��#fj�Y�;_��Ex=��#Fj\�M��,���m�b<b��/3�a�a�, z�+�m$������a�ܑ���}��'��iϜ�2�~G���`�0b��۩݈�.J�;�v�K �� *|Vv#�YY��+�Hu�qޥ�~/�EYG��B����&��2�Y���"�����M��mZ˺���F���) �~�>����g!3+$�/�!�y+˞D%2?�	��\|̈́��-	���Z�&c�/�"3��|H@9P����I���[�<��e���t�P���Fx���eW�b���}Skڜ�,N��G�>��Gm��pVO@�VR���A��z�Zap�x�����oDS�;H?{��j���8����ͭd�`�6<���-��
)����pI˗6�RX��"��C�ßḓ�b�8
��dz���\k�W����CL����ȉ���d�
M"�efK�� �8�뫦���[���`^�P#�h��z�`����c<D�N˜�v�v7�"�x<;��oJ��J�n�< �)��7����K5q%�����wk��
k*�ʩt���;}S4�IL�]�)��OM��Z�?��T�)~��MZ]i�ᖢN��,�g#��8��%��S�4�)H⛚:@љ�{{�IϗL�$;� �)H��"G�Q�1�؃E�D��ײ�.__�l{���LJ����_�#��艶��eGn�4t.�3���	��e�]�nz�O�s<j������-��k����x��%]X�>�)M���h��g��?-;���)���lh�:I���ŀ�f`�3�ʐ�
��;�� �2����I�}}��dW�2����qT�}G�����q�p���nX��-��&�7�����ؕf �?���+Z���R�_<�s�ƻ��_��<�����;���GS�^��/��x��F��>�o��*~�����'�<��˄�L֣�����R:N̑<�b�ye�ʻr��x./!��2m_.��ZU�e1'��N��`����m����Ҙ���8�\t��3T�8�{Ve"+�n�xj��q�����$�uf���k��#t�=��]1P�� ˅wTK�\���+5?����q�c}3�����jm������DF�k7�����xv8y��w��������2�2`n�H�]?S�����L'��B^!-����8��KV-��?�H�W*�g;���� I���oZf�E��,՞��E�]8����%G ֖���l��#<�S���y	��e�
h���&���!�-�q)0j�_^t�Rރ�ֶ��K����q���m�p2\�`	��7��4�N���K0�_Ln�+����K��IxXzK`���@��w�,���a�-�Ma���]uRR�q���,�����F~���z��W;L�% /e����^�����h7��w�����hm;�s���ǫ�کͿa��{|�oƿ�	Bc��{KJ�I�2'�^�O����sr+�p�$��V���8�d-e��sw[������U�4����qo2@xr��|s]���0�J^���/���r(D�Lˌ{~X���
(�7�stRG�d�L�rNx�����V�5�0BZ޽�Ҳ-��ٛ��������[.��&.R�k��_��M�e������T� � �w��B6'2"u���`��B��]i|�a�� ���F��/��n���C���032������'z&��8�Wʿj�a��ʮA���Z�ׯ��+�S�FmKhS��d$/�G��dPFq���`���������Z     