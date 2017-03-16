using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightMinimalStats
	{
		public const short Id = 31;

		public uint lifePoints;

		public uint maxLifePoints;

		public uint baseMaxLifePoints;

		public uint permanentDamagePercent;

		public uint shieldPoints;

		public int actionPoints;

		public int maxActionPoints;

		public int movementPoints;

		public int maxMovementPoints;

		public double summoner;

		public bool summoned;

		public int neutralElementResistPercent;

		public int earthElementResistPercent;

		public int waterElementResistPercent;

		public int airElementResistPercent;

		public int fireElementResistPercent;

		public int neutralElementReduction;

		public int earthElementReduction;

		public int waterElementReduction;

		public int airElementReduction;

		public int fireElementReduction;

		public int criticalDamageFixedResist;

		public int pushDamageFixedResist;

		public int pvpNeutralElementResistPercent;

		public int pvpEarthElementResistPercent;

		public int pvpWaterElementResistPercent;

		public int pvpAirElementResistPercent;

		public int pvpFireElementResistPercent;

		public int pvpNeutralElementReduction;

		public int pvpEarthElementReduction;

		public int pvpWaterElementReduction;

		public int pvpAirElementReduction;

		public int pvpFireElementReduction;

		public uint dodgePALostProbability;

		public uint dodgePMLostProbability;

		public int tackleBlock;

		public int tackleEvade;

		public int fixedDamageReflection;

		public sbyte invisibilityState;

		public virtual short TypeId
		{
			get
			{
				return 31;
			}
		}

		public GameFightMinimalStats()
		{
		}

		public GameFightMinimalStats(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, int actionPoints, int maxActionPoints, int movementPoints, int maxMovementPoints, double summoner, bool summoned, int neutralElementResistPercent, int earthElementResistPercent, int waterElementResistPercent, int airElementResistPercent, int fireElementResistPercent, int neutralElementReduction, int earthElementReduction, int waterElementReduction, int airElementReduction, int fireElementReduction, int criticalDamageFixedResist, int pushDamageFixedResist, int pvpNeutralElementResistPercent, int pvpEarthElementResistPercent, int pvpWaterElementResistPercent, int pvpAirElementResistPercent, int pvpFireElementResistPercent, int pvpNeutralElementReduction, int pvpEarthElementReduction, int pvpWaterElementReduction, int pvpAirElementReduction, int pvpFireElementReduction, uint dodgePALostProbability, uint dodgePMLostProbability, int tackleBlock, int tackleEvade, int fixedDamageReflection, sbyte invisibilityState)
		{
			this.lifePoints = lifePoints;
			this.maxLifePoints = maxLifePoints;
			this.baseMaxLifePoints = baseMaxLifePoints;
			this.permanentDamagePercent = permanentDamagePercent;
			this.shieldPoints = shieldPoints;
			this.actionPoints = actionPoints;
			this.maxActionPoints = maxActionPoints;
			this.movementPoints = movementPoints;
			this.maxMovementPoints = maxMovementPoints;
			this.summoner = summoner;
			this.summoned = summoned;
			this.neutralElementResistPercent = neutralElementResistPercent;
			this.earthElementResistPercent = earthElementResistPercent;
			this.waterElementResistPercent = waterElementResistPercent;
			this.airElementResistPercent = airElementResistPercent;
			this.fireElementResistPercent = fireElementResistPercent;
			this.neutralElementReduction = neutralElementReduction;
			this.earthElementReduction = earthElementReduction;
			this.waterElementReduction = waterElementReduction;
			this.airElementReduction = airElementReduction;
			this.fireElementReduction = fireElementReduction;
			this.criticalDamageFixedResist = criticalDamageFixedResist;
			this.pushDamageFixedResist = pushDamageFixedResist;
			this.pvpNeutralElementResistPercent = pvpNeutralElementResistPercent;
			this.pvpEarthElementResistPercent = pvpEarthElementResistPercent;
			this.pvpWaterElementResistPercent = pvpWaterElementResistPercent;
			this.pvpAirElementResistPercent = pvpAirElementResistPercent;
			this.pvpFireElementResistPercent = pvpFireElementResistPercent;
			this.pvpNeutralElementReduction = pvpNeutralElementReduction;
			this.pvpEarthElementReduction = pvpEarthElementReduction;
			this.pvpWaterElementReduction = pvpWaterElementReduction;
			this.pvpAirElementReduction = pvpAirElementReduction;
			this.pvpFireElementReduction = pvpFireElementReduction;
			this.dodgePALostProbability = dodgePALostProbability;
			this.dodgePMLostProbability = dodgePMLostProbability;
			this.tackleBlock = tackleBlock;
			this.tackleEvade = tackleEvade;
			this.fixedDamageReflection = fixedDamageReflection;
			this.invisibilityState = invisibilityState;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.lifePoints = reader.ReadVarUhInt();
			this.maxLifePoints = reader.ReadVarUhInt();
			this.baseMaxLifePoints = reader.ReadVarUhInt();
			this.permanentDamagePercent = reader.ReadVarUhInt();
			this.shieldPoints = reader.ReadVarUhInt();
			this.actionPoints = reader.ReadVarShort();
			this.maxActionPoints = reader.ReadVarShort();
			this.movementPoints = reader.ReadVarShort();
			this.maxMovementPoints = reader.ReadVarShort();
			this.summoner = reader.ReadDouble();
			this.summoned = reader.ReadBoolean();
			this.neutralElementResistPercent = reader.ReadVarShort();
			this.earthElementResistPercent = reader.ReadVarShort();
			this.waterElementResistPercent = reader.ReadVarShort();
			this.airElementResistPercent = reader.ReadVarShort();
			this.fireElementResistPercent = reader.ReadVarShort();
			this.neutralElementReduction = reader.ReadVarShort();
			this.earthElementReduction = reader.ReadVarShort();
			this.waterElementReduction = reader.ReadVarShort();
			this.airElementReduction = reader.ReadVarShort();
			this.fireElementReduction = reader.ReadVarShort();
			this.criticalDamageFixedResist = reader.ReadVarShort();
			this.pushDamageFixedResist = reader.ReadVarShort();
			this.pvpNeutralElementResistPercent = reader.ReadVarShort();
			this.pvpEarthElementResistPercent = reader.ReadVarShort();
			this.pvpWaterElementResistPercent = reader.ReadVarShort();
			this.pvpAirElementResistPercent = reader.ReadVarShort();
			this.pvpFireElementResistPercent = reader.ReadVarShort();
			this.pvpNeutralElementReduction = reader.ReadVarShort();
			this.pvpEarthElementReduction = reader.ReadVarShort();
			this.pvpWaterElementReduction = reader.ReadVarShort();
			this.pvpAirElementReduction = reader.ReadVarShort();
			this.pvpFireElementReduction = reader.ReadVarShort();
			this.dodgePALostProbability = reader.ReadVarUhShort();
			this.dodgePMLostProbability = reader.ReadVarUhShort();
			this.tackleBlock = reader.ReadVarShort();
			this.tackleEvade = reader.ReadVarShort();
			this.fixedDamageReflection = reader.ReadVarShort();
			this.invisibilityState = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.lifePoints);
			writer.WriteVarInt((int)this.maxLifePoints);
			writer.WriteVarInt((int)this.baseMaxLifePoints);
			writer.WriteVarInt((int)this.permanentDamagePercent);
			writer.WriteVarInt((int)this.shieldPoints);
			writer.WriteVarShort(this.actionPoints);
			writer.WriteVarShort(this.maxActionPoints);
			writer.WriteVarShort(this.movementPoints);
			writer.WriteVarShort(this.maxMovementPoints);
			writer.WriteDouble(this.summoner);
			writer.WriteBoolean(this.summoned);
			writer.WriteVarShort(this.neutralElementResistPercent);
			writer.WriteVarShort(this.earthElementResistPercent);
			writer.WriteVarShort(this.waterElementResistPercent);
			writer.WriteVarShort(this.airElementResistPercent);
			writer.WriteVarShort(this.fireElementResistPercent);
			writer.WriteVarShort(this.neutralElementReduction);
			writer.WriteVarShort(this.earthElementReduction);
			writer.WriteVarShort(this.waterElementReduction);
			writer.WriteVarShort(this.airElementReduction);
			writer.WriteVarShort(this.fireElementReduction);
			writer.WriteVarShort(this.criticalDamageFixedResist);
			writer.WriteVarShort(this.pushDamageFixedResist);
			writer.WriteVarShort(this.pvpNeutralElementResistPercent);
			writer.WriteVarShort(this.pvpEarthElementResistPercent);
			writer.WriteVarShort(this.pvpWaterElementResistPercent);
			writer.WriteVarShort(this.pvpAirElementResistPercent);
			writer.WriteVarShort(this.pvpFireElementResistPercent);
			writer.WriteVarShort(this.pvpNeutralElementReduction);
			writer.WriteVarShort(this.pvpEarthElementReduction);
			writer.WriteVarShort(this.pvpWaterElementReduction);
			writer.WriteVarShort(this.pvpAirElementReduction);
			writer.WriteVarShort(this.pvpFireElementReduction);
			writer.WriteVarShort((int)this.dodgePALostProbability);
			writer.WriteVarShort((int)this.dodgePMLostProbability);
			writer.WriteVarShort(this.tackleBlock);
			writer.WriteVarShort(this.tackleEvade);
			writer.WriteVarShort(this.fixedDamageReflection);
			writer.WriteSByte(this.invisibilityState);
		}
	}
}