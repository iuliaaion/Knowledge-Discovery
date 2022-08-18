<?xml version="1.0" encoding="UTF-8"?>
<conceptualSchema version="TJ1.0">
    <databaseConnection>
        <embed url="/C:/Users/Iulia%20Ion/Desktop/stroke_dataset.sql" />
        <table name="MYTABLE" />
        <key name="ID" />
    </databaseConnection>
    <diagram title="Smoke_status">
        <node id="0">
            <position x="0.0" y="0.0" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>NOT (MYTABLE.SMOKING_STATUS = 'formerly smoked') AND NOT (MYTABLE.SMOKING_STATUS = 'never smoked') AND NOT (MYTABLE.SMOKING_STATUS = 'smokes')</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="1">
            <position x="76.00000000000001" y="90.00000000000001" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.SMOKING_STATUS = 'smokes'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>smokes</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="2">
            <position x="-43.39645630121231" y="272.0978317260742" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="3">
            <position x="-8.753870546817783" y="90.25322723388673" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.SMOKING_STATUS = 'never smoked'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>never smoked</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="4">
            <position x="-110.64258575439455" y="91.84460449218751" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.SMOKING_STATUS = 'formerly smoked'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>formerly smoked</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <edge from="0" to="1" />
        <edge from="1" to="2" />
        <edge from="3" to="2" />
        <edge from="4" to="2" />
        <edge from="0" to="3" />
        <edge from="0" to="4" />
        <projectionBase>
            <vector x="76.0" y="90.0" />
            <vector x="6.0" y="80.0" />
            <vector x="-134.0" y="180.0" />
        </projectionBase>
    </diagram>
    <diagram title="Work_type">
        <node id="0">
            <position x="131.99986257553084" y="47.43574066162098" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.WORK_TYPE = 'Govt_job'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>Govt_job</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="1">
            <position x="72.25411214828495" y="79.1059562683106" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.WORK_TYPE = 'children'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>children</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="2">
            <position x="-132.59069070816093" y="27.979499053954896" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.WORK_TYPE = 'Never_worked'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>Never_worked</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="3">
            <position x="8.339535140991218" y="50.53351325988759" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.WORK_TYPE = 'Self-employed'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>Self-employed</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="4">
            <position x="14.331966400145575" y="252.61393547058367" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="5">
            <position x="-65.67085275650044" y="47.55922622680654" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>MYTABLE.WORK_TYPE = 'Private'</object>
                </objectContingent>
                <attributeContingent>
                    <attribute>Private</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="6">
            <position x="0.0" y="0.0" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object>NOT (MYTABLE.WORK_TYPE = 'Govt_job') AND NOT (MYTABLE.WORK_TYPE = 'Never_worked') AND NOT (MYTABLE.WORK_TYPE = 'Private') AND NOT (MYTABLE.WORK_TYPE = 'Self-employed') AND NOT (MYTABLE.WORK_TYPE = 'children')</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <edge from="6" to="0" />
        <edge from="6" to="1" />
        <edge from="6" to="2" />
        <edge from="6" to="3" />
        <edge from="0" to="4" />
        <edge from="1" to="4" />
        <edge from="2" to="4" />
        <edge from="3" to="4" />
        <edge from="5" to="4" />
        <edge from="6" to="5" />
        <projectionBase>
            <vector x="80.875" y="80.625" />
            <vector x="39.0" y="42.5" />
            <vector x="11.5" y="30.0" />
            <vector x="-28.5" y="50.0" />
            <vector x="-153.5" y="165.0" />
        </projectionBase>
    </diagram>
    <diagram title="Age_increasing">
        <node id="0">
            <position x="-86.2105638627587" y="369.4738451261088" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="0">(AGE&gt;=65) AND (AGE&lt;74)</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="0">&gt;=65</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="1">
            <position x="-57.473709241839146" y="246.31589675073923" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="1">(AGE&gt;=64) AND (AGE&lt;65)</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="1">&gt;=64</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="2">
            <position x="-114.94741848367829" y="492.63179350147846" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="2">(AGE&gt;=74)</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="2">&gt;=74</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>4.0</coordinate>
            </ndimVector>
        </node>
        <node id="3">
            <position x="0.0" y="0.0" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="3">(AGE&lt;55)</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="4">
            <position x="-28.736854620919573" y="123.15794837536961" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="4">(AGE&gt;=55) AND (AGE&lt;64)</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="3">&gt;=55</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <edge from="1" to="0" />
        <edge from="4" to="1" />
        <edge from="0" to="2" />
        <edge from="3" to="4" />
        <projectionBase>
            <vector x="-56.0" y="240.0" />
        </projectionBase>
    </diagram>
    <diagram title="Age_Bound">
        <node id="0">
            <position x="-43.186325706197096" y="136.93225223916153" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="1">
            <position x="-14.746550241140476" y="84.26600137794554" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="2">
            <position x="82.15935134349695" y="189.59850310037757" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="0">&gt;= 74</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>6.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="3">
            <position x="-57.93287594733758" y="221.19825361710707" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="4">
            <position x="-72.67942618847803" y="305.46425499505256" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="0">AGE &gt;= 56 AND AGE &lt; 64</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
                <coordinate>4.0</coordinate>
            </ndimVector>
        </node>
        <node id="5">
            <position x="-156.94542756642363" y="347.5972556840254" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="1">AGE &gt;= 50 AND AGE &lt; 55</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>6.0</coordinate>
            </ndimVector>
        </node>
        <node id="6">
            <position x="-170.63865279033973" y="315.9975051672958" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="1">&lt; 55</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>6.0</coordinate>
            </ndimVector>
        </node>
        <node id="7">
            <position x="26.333125430607993" y="179.06525292813433" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>4.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="8">
            <position x="40.02635065452412" y="210.66500344486394" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>5.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="9">
            <position x="-56.87955093011328" y="105.33250172243197" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="2">&lt; 74</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="10">
            <position x="0.0" y="0.0" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="11">
            <position x="27.386450447832317" y="63.1995010334592" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="3">&gt;= 55</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="12">
            <position x="11.58657518946751" y="263.3312543060798" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="2">AGE &gt;= 65 AND AGE &lt; 74</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>5.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="13">
            <position x="-142.19887732528315" y="263.3312543060798" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="4">&lt; 56</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>5.0</coordinate>
            </ndimVector>
        </node>
        <node id="14">
            <position x="68.46612611958076" y="157.9987525836479" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="5">&gt;= 65</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>5.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="15">
            <position x="-44.239650723421434" y="252.7980041338368" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="16">
            <position x="12.639900206691834" y="147.4655024114047" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="17">
            <position x="53.71957587844028" y="242.26475396159356" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="3">AGE &gt;= 74 AND AGE &lt; 75</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>6.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="18">
            <position x="-113.75910186022656" y="210.66500344486394" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="6">&lt; 64</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>4.0</coordinate>
            </ndimVector>
        </node>
        <node id="19">
            <position x="54.772900895664634" y="126.3990020669184" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="7">&gt;= 64</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>4.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="20">
            <position x="-114.81242687745089" y="326.53075533953904" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="4">AGE &gt;= 55 AND AGE &lt; 56</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>5.0</coordinate>
            </ndimVector>
        </node>
        <node id="21">
            <position x="95.85257656741305" y="221.19825361710707" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="5">AGE &gt;= 75</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="8">&gt;= 75</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>7.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="22">
            <position x="-2.106650034448638" y="231.7315037893503" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>4.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="23">
            <position x="-199.07842825539637" y="368.6637560285121" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="6">AGE &lt; 50</object>
                </objectContingent>
                <attributeContingent>
                    <attribute contextPosition="9">&lt; 50</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>7.0</coordinate>
            </ndimVector>
        </node>
        <node id="24">
            <position x="-71.62610117125374" y="189.59850310037757" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="25">
            <position x="-15.7998752583648" y="200.1317532726207" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="26">
            <position x="-29.49310048228095" y="168.53200275589109" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>2.0</coordinate>
            </ndimVector>
        </node>
        <node id="27">
            <position x="41.079675671748475" y="94.79925155018879" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="10">&gt;= 56</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>3.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="28">
            <position x="-85.31932639516987" y="157.9987525836479" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="11">&lt; 65</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="29">
            <position x="13.693225223916158" y="31.5997505167296" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="12">&gt;= 50</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>0.0</coordinate>
            </ndimVector>
        </node>
        <node id="30">
            <position x="-100.06587663631035" y="242.26475396159356" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>4.0</coordinate>
            </ndimVector>
        </node>
        <node id="31">
            <position x="-30.54642549950526" y="284.3977546505663" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent>
                    <object contextPosition="7">AGE &gt;= 64 AND AGE &lt; 65</object>
                </objectContingent>
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>4.0</coordinate>
                <coordinate>3.0</coordinate>
            </ndimVector>
        </node>
        <node id="32">
            <position x="-86.37265141239419" y="273.86450447832306" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>4.0</coordinate>
            </ndimVector>
        </node>
        <node id="33">
            <position x="-103.22585168798332" y="589.8620096456189" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>7.0</coordinate>
                <coordinate>7.0</coordinate>
            </ndimVector>
        </node>
        <node id="34">
            <position x="-1.053325017224319" y="115.86575189467516" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>2.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <node id="35">
            <position x="-128.50565210136688" y="294.9310048228094" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent />
            </concept>
            <ndimVector>
                <coordinate>1.0</coordinate>
                <coordinate>5.0</coordinate>
            </ndimVector>
        </node>
        <node id="36">
            <position x="-28.43977546505664" y="52.666250861215985" />
            <attributeLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </attributeLabelStyle>
            <objectLabelStyle>
                <offset x="0.0" y="0.0" />
                <backgroundColor>#ffffffff</backgroundColor>
                <textColor>#ff000000</textColor>
                <textAlignment>left</textAlignment>
            </objectLabelStyle>
            <concept>
                <objectContingent />
                <attributeContingent>
                    <attribute contextPosition="13">&lt; 75</attribute>
                </attributeContingent>
            </concept>
            <ndimVector>
                <coordinate>0.0</coordinate>
                <coordinate>1.0</coordinate>
            </ndimVector>
        </node>
        <edge from="1" to="0" />
        <edge from="9" to="0" />
        <edge from="36" to="1" />
        <edge from="29" to="1" />
        <edge from="14" to="2" />
        <edge from="24" to="3" />
        <edge from="26" to="3" />
        <edge from="32" to="4" />
        <edge from="15" to="4" />
        <edge from="6" to="5" />
        <edge from="35" to="5" />
        <edge from="13" to="6" />
        <edge from="19" to="7" />
        <edge from="16" to="7" />
        <edge from="7" to="8" />
        <edge from="14" to="8" />
        <edge from="36" to="9" />
        <edge from="29" to="11" />
        <edge from="22" to="12" />
        <edge from="8" to="12" />
        <edge from="18" to="13" />
        <edge from="19" to="14" />
        <edge from="3" to="15" />
        <edge from="25" to="15" />
        <edge from="34" to="16" />
        <edge from="27" to="16" />
        <edge from="2" to="17" />
        <edge from="8" to="17" />
        <edge from="28" to="18" />
        <edge from="27" to="19" />
        <edge from="32" to="20" />
        <edge from="35" to="20" />
        <edge from="2" to="21" />
        <edge from="7" to="22" />
        <edge from="25" to="22" />
        <edge from="6" to="23" />
        <edge from="0" to="24" />
        <edge from="28" to="24" />
        <edge from="26" to="25" />
        <edge from="16" to="25" />
        <edge from="0" to="26" />
        <edge from="34" to="26" />
        <edge from="11" to="27" />
        <edge from="9" to="28" />
        <edge from="10" to="29" />
        <edge from="18" to="30" />
        <edge from="24" to="30" />
        <edge from="22" to="31" />
        <edge from="15" to="31" />
        <edge from="3" to="32" />
        <edge from="30" to="32" />
        <edge from="4" to="33" />
        <edge from="5" to="33" />
        <edge from="12" to="33" />
        <edge from="17" to="33" />
        <edge from="20" to="33" />
        <edge from="21" to="33" />
        <edge from="23" to="33" />
        <edge from="31" to="33" />
        <edge from="1" to="34" />
        <edge from="11" to="34" />
        <edge from="30" to="35" />
        <edge from="13" to="35" />
        <edge from="10" to="36" />
        <projectionBase>
            <vector x="52.0" y="120.0" />
            <vector x="-108.0" y="200.0" />
        </projectionBase>
    </diagram>
</conceptualSchema>

