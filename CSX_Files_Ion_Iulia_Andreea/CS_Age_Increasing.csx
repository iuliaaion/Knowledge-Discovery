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
</conceptualSchema>

