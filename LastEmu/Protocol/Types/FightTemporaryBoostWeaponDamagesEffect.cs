using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
	{
		public const short Id = 211;

		public short weaponTypeId;

		public override short TypeId
		{
			get
			{
				return 211;
			}
		}

		public FightTemporaryBoostWeaponDamagesEffect()
		{
		}

		public FightTemporaryBoostWeaponDamagesEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, short delta, short weaponTypeId) : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
		{
			this.weaponTypeId = weaponTypeId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.weaponTypeId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.weaponTypeId);
		}
	}
}