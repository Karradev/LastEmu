using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractFightDispellableEffect
	{
		public const short Id = 206;

		public uint uid;

		public double targetId;

		public short turnDuration;

		public sbyte dispelable;

		public uint spellId;

		public uint effectId;

		public uint parentBoostUid;

		public virtual short TypeId
		{
			get
			{
				return 206;
			}
		}

		public AbstractFightDispellableEffect()
		{
		}

		public AbstractFightDispellableEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid)
		{
			this.uid = uid;
			this.targetId = targetId;
			this.turnDuration = turnDuration;
			this.dispelable = dispelable;
			this.spellId = spellId;
			this.effectId = effectId;
			this.parentBoostUid = parentBoostUid;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadVarUhInt();
			this.targetId = reader.ReadDouble();
			this.turnDuration = reader.ReadShort();
			this.dispelable = reader.ReadSByte();
			this.spellId = reader.ReadVarUhShort();
			this.effectId = reader.ReadVarUhInt();
			this.parentBoostUid = reader.ReadVarUhInt();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.uid);
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.turnDuration);
			writer.WriteSByte(this.dispelable);
			writer.WriteVarShort((int)this.spellId);
			writer.WriteVarInt((int)this.effectId);
			writer.WriteVarInt((int)this.parentBoostUid);
		}
	}
}